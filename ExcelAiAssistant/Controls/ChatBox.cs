using ExcelAiAssistant.Components;
using ExcelAiAssistant.Interfaces;
using ExcelAiAssistant.Languages;
using ExcelAiAssistant.Models;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExcelAiAssistant.Controls
{
    public partial class ChatBox : UserControl
    {
        private List<Config> _configs;
        private IChatService _chatService;
        public Conversation _conversation;
        public ChatBox()
        {           
            InitializeComponent();
            LoadModelConfig();
            LoadChatHistory();
            InitDefaultChat();

            LanguageManager.LanguageChanged += OnLanguageChanged;
            this.OnLanguageChanged();
        }

        private void OnLanguageChanged()
        {
            if(this._conversation?.Spans?.Count <=0)
            {
                this.lbChatTitle.Text = Strings.ChatBox_Caption;
            }
            this.tsbNewChat.Text = Strings.ChatBox_btnNewChat_Tips;
            this.tsbNewChat.ToolTipText = Strings.ChatBox_btnNewChat_Tips;
            this.ddbHistory.Text = Strings.ChatBox_btnHistory_Tips;
            this.ddbHistory.ToolTipText = Strings.ChatBox_btnHistory_Tips;

            if(this.tsddModels.Tag == null)
            {
                this.tsddModels.Text = Strings.ChatBox_menuChangeModel_ErrorNote;
            }
            this.btnSendMsg.Text = Strings.ChatBox_btnSend_Text;
            this.btnSendMsg.ToolTipText = Strings.ChatBox_btnSend_Tips;

            this.tsmiSelectAll.Text = Strings.Global_Operation_SelectAll;
            this.tsmiCopy.Text = Strings.Global_Operation_Copy;
            this.tsmiPaste.Text = Strings.Global_Operation_Paste;
        }

        #region history
        private void LoadChatHistory()
        {
            try
            {
                var historyFileList = Conversation.GetHistoryFiles();
                foreach (var historyFile in historyFileList.Skip(Math.Max(0, historyFileList.Count - 15)))
                {
                    this.AddHistory(historyFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ChatBox_LoadChatHistory");
            }
        }

        private void AddHistory(ConversationInfo ci)
        {
            var item = new ToolStripMenuItem(ci.Title);
            item.Tag = ci;
            item.Click += Item_History_Click;
            ddbHistory.DropDownItems.Insert(0,item);
        }

        private void Item_History_Click(object sender, EventArgs e)
        {
            if(_configs == null || _configs.Count == 0)
            {
                MessageBox.Show(Strings.ChatBox_menuChangeModel_ErrorNote, Strings.Global_Operation_Failure, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = sender as ToolStripMenuItem;
            if (item != null)
            {
                ConversationInfo ci = item.Tag as ConversationInfo;
                if (ci != null)
                {
                    this.SaveAndCleanConversation();

                    _conversation = ci.Content;

                    try
                    {
                        var matchingConfig = _configs.FirstOrDefault(config =>
                            config.BaseUrl == _conversation.ModelConfig.BaseUrl &&
                            config.AppKey == _conversation.ModelConfig.AppKey &&
                            config.ModelName == _conversation.ModelConfig.ModelName &&
                            config.ApiType == _conversation.ModelConfig.ApiType &&
                            config.Enabled == _conversation.ModelConfig.Enabled &&
                            config.SystemPrompt == _conversation.ModelConfig.SystemPrompt);

                        this.SetModel(matchingConfig);
                    }
                    catch
                    {
                        this.SetModel(tsddModels.DropDownItems[0].Tag as Config);
                    }

                    foreach (Span span in _conversation.Spans)
                    {
                        if (span.IsQuestion)
                        {
                            AddQuestion(span);
                        }
                        else
                        {
                            if (span.Type == "Code")
                            {
                                AddCode(span);
                            }
                            else if (span.Type == "Append")
                            {
                                AppendAnswer(span.Text);
                            }
                            else
                            {
                                AddAnswer(span);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region InitNewChat SetModel
        public void LoadModelConfig()
        {
            try
            {
                this.tsddModels.DropDownItems.Clear();
                this.tsddModels.Tag = null;
                this.tsddModels.Image = Properties.Resources.ollama;
                this.tsddModels.Text = Strings.ChatBox_menuChangeModel_ErrorNote;

                _configs = ConfigHelper.LoadModelConfigFromFile(ThisAddIn.ConfigFilePath(),true);


                foreach (var config in _configs)
                {
                    var item = new ToolStripMenuItem(config.ModelName);
                    item.Tag = config;
                    // 根据 ApiType 设置图像
                    if (config.ApiType == "Ollama Type")
                    {
                        item.Image = Properties.Resources.ollama;
                    }
                    else if (config.ApiType == "OpenAI Type")
                    {
                        item.Image = Properties.Resources.openai;
                    }
                    else
                    {
                        item.Image = Properties.Resources.ExistLink_16x16;
                    }
                    this.tsddModels.DropDownItems.Add(item);
                    item.Click += Item_Click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ChatBox_LoadModelConfig");
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item != null && item.Tag != this.tsddModels.Tag)
            {
                Config config = item.Tag as Config;
                if (config != null)
                {
                    this.SetModel(config);
                }
            }
        }

        private void SetModel(Config config)
        {
            if (config != null)
            {
                this.tsddModels.Text = config.ModelName;
                if (config.ApiType == "Ollama Type")
                {
                    tsddModels.Image = Properties.Resources.ollama;
                }
                else if (config.ApiType == "OpenAI Type")
                {
                    tsddModels.Image = Properties.Resources.openai;
                }
                else
                {
                    tsddModels.Image = Properties.Resources.ExistLink_16x16;
                }
                this.tsddModels.Tag = config;
                this._conversation.ModelConfig = config;
                this.InitChatService();
            }
        }

        private void tsbNewChat_Click(object sender, EventArgs e)
        {
            if(this._conversation != null && this._conversation.Spans != null && this._conversation.Spans.Count > 0)
            {
                this.SaveAndCleanConversation();
            }

            if (this.tsddModels.Tag != null)
            {
                _conversation = new Conversation();
                _conversation.ModelConfig = this.tsddModels.Tag as Config;
                this.lbChatTitle.Text = _conversation.Title;
                this.SetModel(_conversation.ModelConfig);
            }
            else
            {
                MessageBox.Show(Strings.ChatBox_menuChangeModel_ErrorNote, Strings.Global_Operation_Failure, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InitDefaultChat()
        {
            try
            {
                _conversation = new Conversation();
                this.lbChatTitle.Text = _conversation.Title;
                if (this.tsddModels.DropDownItems.Count > 0)
                {
                    var config = this.tsddModels.DropDownItems[0].Tag as Config;
                    this.SetModel(config);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ChatBox_InitNewChat");
            }
        }

        public void SaveAndCleanConversation()
        {
            if (_conversation!=null && _conversation.Spans.Count > 1)
            {
                string filepath = _conversation.SaveToFile();
                this.AddHistory(Conversation.CreateConversationInfo(filepath));
                this.spcMain.Panel1.Controls.Clear();
            }
        }

        
        private void InitChatService()
        {
            _conversation.Spans.CollectionChanged -= Spans_CollectionChanged;
            var config = _conversation.ModelConfig;
            switch (config.ApiType)
            {
                case "Ollama Type":
                    {
                        _chatService = new OllamaChatService(config);
                        break;
                    }
                case "OpenAI Type":
                    {
                        _chatService = new OpenAiChatService(config);
                        break;
                    }
                default:
                    {
                        _chatService = new GeneralAiClient(config);
                        break;
                    }
            }
            _conversation.Spans.CollectionChanged += Spans_CollectionChanged;
        }

        private void Spans_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Span span in e.NewItems)
                {
                    if (span.IsQuestion)
                    {
                        AddQuestion(span);
                    }
                    else
                    {
                        if (span.Type == "Code")
                        {
                            AddCode(span);
                        }
                        else if (span.Type == "Append")
                        {
                            AppendAnswer(span.Text);
                        }
                        else
                        {
                            AddAnswer(span);
                        }
                    }
                    this.spcMain.Panel1.ScrollControlIntoView(this.spcMain.Panel1.Controls[0]);
                }
            }
        }

        #endregion

        private void AddQuestion(Span span)
        {
            this.lbChatTitle.Text = _conversation.Title;
            var questionBox = new QuestionBox(this.spcMain.Panel1);
            questionBox.Question = span.Text;
            //questionBox.Dock = DockStyle.Top;
            this.spcMain.Panel1.Controls.Add(questionBox);
            this.spcMain.Panel1.Controls.SetChildIndex(questionBox, 0);
        }

        private void AddAnswer(Span span)
        {
            var answerBox = new AnswerBox(this.spcMain.Panel1);
            answerBox.Answer = span.Text;
            //answerBox.Dock = DockStyle.Top;
            this.spcMain.Panel1.Controls.Add(answerBox);
            this.spcMain.Panel1.Controls.SetChildIndex(answerBox, 0);
        }

        private void AddCode(Span span)
        {
            var codeBox = new CodeEditor();
            codeBox.Code = span.Text;
            this.spcMain.Panel1.Controls.Add(codeBox);
            this.spcMain.Panel1.Controls.SetChildIndex(codeBox, 0);
        }

        private void AppendAnswer(string text)
        {
            var AnswerAppendBox = new AnswerAppendBox(this.spcMain.Panel1);
            AnswerAppendBox.Answer = text;
            this.spcMain.Panel1.Controls.Add(AnswerAppendBox);
            this.spcMain.Panel1.Controls.SetChildIndex(AnswerAppendBox, 0);
        }        

        

        private async void btnSendMsg_Click(object sender, EventArgs e)
        {
            if(_conversation == null || _conversation.ModelConfig == null)
            {
                MessageBox.Show(this, Strings.ChatBox_menuChangeModel_ErrorNote, Strings.Global_Operation_Failure, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(this.txtSendMsg.Text))
            {                

                string content = this.txtSendMsg.Text.Trim(Environment.NewLine.ToCharArray());
                _conversation.AddQuestion(content);
                this.txtSendMsg.Text = "";

                btnSendMsg.Visible = false;
                tspbWaiting.Visible = true;

                try
                {
                    // 发送问题并接收答案
                    var answer = await _chatService.SendMessageAsync(content, _conversation);

                    // 分离代码块和文本部分
                    var spans = MarkdownHelper.ParseMarkdown(answer);

                    foreach (var span in spans)
                    {
                        if (span.Type == "Code")
                        {
                            _conversation.AddCode(span.Text);
                        }
                        else if (span.Type == "Append")
                        {
                            _conversation.AppendAnswer(span.Text);
                        }
                        else
                        {
                            _conversation.AddAnswer(span.Text);
                        }
                    }
                }
                finally
                {
                    this.Invoke((MethodInvoker)delegate {
                        btnSendMsg.Visible = true;
                        tspbWaiting.Visible = false;
                    });
                }
            }
        }

        private void txtSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnSendMsg_Click(sender, e);
                e.SuppressKeyPress = true; // 防止在文本框中输入换行符
            }
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            this.txtSendMsg.SelectAll();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtSendMsg.SelectedText))
            {
                Clipboard.SetText(this.txtSendMsg.SelectedText);
            }
            else
            {
                Clipboard.SetText(this.txtSendMsg.Text);
            }
        }

        private void txtSendMsg_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuEdit.Show(txtSendMsg, e.Location);
            }
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                this.txtSendMsg.Paste();
            }
        }

        
    }


}
