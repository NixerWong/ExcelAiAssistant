using ExcelAiAssistant.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ExcelAiAssistant.Controls
{
    public partial class QuestionBox : UserControl
    {

        public string Question
        {
            get
            {
                return txtQuestion.Text;
            }
            set
            {
                txtQuestion.Text = value;
                AdjustHeight();
            }
        }

        private void AdjustHeight()
        {
            if (this.txtQuestion != null)
            {
                //using (Graphics g = this.CreateGraphics())
                //{
                //    // 测量文本的高度
                //    SizeF textSize = g.MeasureString(txtQuestion.Text, txtQuestion.Font, txtQuestion.Width);
                //    // 设置 AnswerBox 的高度
                //    int h = (int)Math.Ceiling(textSize.Height) ;
                //     Size singleLineSize = TextRenderer.MeasureText("中", txtQuestion.Font);
                //    //主要是多行时没有考虑行间距
                //    int lineCount = (int)Math.Ceiling(Convert.ToDecimal(textSize.Height) / Convert.ToDecimal((singleLineSize.Height)));
                //    if (lineCount > 1)
                //    {
                //        h += (lineCount - 1) * 1;
                //    }

                //    this.Height = h + this.tableLayoutPanel.Padding.Vertical + this.txtQuestion.Margin.Top + this.txtQuestion.Margin.Bottom + Padding.Top + Padding.Bottom;                    
                //}

                int lineCount = txtQuestion.GetLineFromCharIndex(txtQuestion.TextLength) + 1;

                // 获取每行的高度 加行间距
                int lineHeight = TextRenderer.MeasureText("中", txtQuestion.Font).Height + 4;

                // 计算控件的高度
                int h = lineCount * lineHeight + this.tableLayoutPanel.Padding.Vertical + this.txtQuestion.Margin.Top + this.txtQuestion.Margin.Bottom + Padding.Top + Padding.Bottom;

                this.Height = h;
            }
        }

        public QuestionBox(Control parent)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //this.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.Parent = parent;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            LanguageManager.LanguageChanged += OnLanguageChanged;
            this.OnLanguageChanged();
        }

        private void OnLanguageChanged()
        {
            this.tsmiCopy.Text = Strings.Global_Operation_Copy;
            this.tsmiSelectAll.Text = Strings.Global_Operation_SelectAll;
        }

        private void QuestionBox_Load(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void QuestionBox_SizeChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void txtQuestion_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuEdit.Show(txtQuestion, e.Location);
            }            
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            this.txtQuestion.SelectAll();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtQuestion.SelectedText))
            {
                Clipboard.SetText(this.txtQuestion.SelectedText);
            }
            else
            {
                Clipboard.SetText(this.txtQuestion.Text);
            }
        }
    }
}
