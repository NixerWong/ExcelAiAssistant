namespace ExcelAiAssistant.Controls
{
    partial class ChatBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topBar = new System.Windows.Forms.ToolStrip();
            this.lbChatTitle = new System.Windows.Forms.ToolStripLabel();
            this.ddbHistory = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbNewChat = new System.Windows.Forms.ToolStripButton();
            this.barSendMsg = new System.Windows.Forms.ToolStrip();
            this.btnSendMsg = new System.Windows.Forms.ToolStripButton();
            this.tspbWaiting = new System.Windows.Forms.ToolStripProgressBar();
            this.tsddModels = new System.Windows.Forms.ToolStripDropDownButton();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.txtSendMsg = new System.Windows.Forms.RichTextBox();
            this.menuEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tss = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.topBar.SuspendLayout();
            this.barSendMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.menuEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.AutoSize = false;
            this.topBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.topBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.topBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbChatTitle,
            this.ddbHistory,
            this.tsbNewChat});
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Padding = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.topBar.Size = new System.Drawing.Size(491, 40);
            this.topBar.TabIndex = 5;
            this.topBar.Text = "聊天窗口标题栏";
            // 
            // lbChatTitle
            // 
            this.lbChatTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbChatTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbChatTitle.Image = global::ExcelAiAssistant.Properties.Resources.EAA_16;
            this.lbChatTitle.Name = "lbChatTitle";
            this.lbChatTitle.Size = new System.Drawing.Size(72, 31);
            this.lbChatTitle.Text = "聊天标题";
            // 
            // ddbHistory
            // 
            this.ddbHistory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ddbHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ddbHistory.Image = global::ExcelAiAssistant.Properties.Resources.HistoryItem_16x16;
            this.ddbHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbHistory.Name = "ddbHistory";
            this.ddbHistory.Padding = new System.Windows.Forms.Padding(3);
            this.ddbHistory.Size = new System.Drawing.Size(35, 31);
            this.ddbHistory.Text = "历史对话";
            // 
            // tsbNewChat
            // 
            this.tsbNewChat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNewChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewChat.Image = global::ExcelAiAssistant.Properties.Resources.EditComment_16x16;
            this.tsbNewChat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewChat.Name = "tsbNewChat";
            this.tsbNewChat.Size = new System.Drawing.Size(23, 31);
            this.tsbNewChat.Text = "新建对话";
            this.tsbNewChat.Click += new System.EventHandler(this.tsbNewChat_Click);
            // 
            // barSendMsg
            // 
            this.barSendMsg.AutoSize = false;
            this.barSendMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.barSendMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barSendMsg.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barSendMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSendMsg,
            this.tspbWaiting,
            this.tsddModels});
            this.barSendMsg.Location = new System.Drawing.Point(0, 585);
            this.barSendMsg.Name = "barSendMsg";
            this.barSendMsg.Padding = new System.Windows.Forms.Padding(7, 5, 5, 5);
            this.barSendMsg.Size = new System.Drawing.Size(491, 35);
            this.barSendMsg.TabIndex = 7;
            this.barSendMsg.Text = "sendMsgBar";
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSendMsg.AutoSize = false;
            this.btnSendMsg.Image = global::ExcelAiAssistant.Properties.Resources.PreviousComment_16x16;
            this.btnSendMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(80, 22);
            this.btnSendMsg.Text = "发送";
            this.btnSendMsg.ToolTipText = "发送（Ctrl+Enter）";
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // tspbWaiting
            // 
            this.tspbWaiting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspbWaiting.AutoSize = false;
            this.tspbWaiting.Name = "tspbWaiting";
            this.tspbWaiting.Size = new System.Drawing.Size(80, 13);
            this.tspbWaiting.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.tspbWaiting.Visible = false;
            // 
            // tsddModels
            // 
            this.tsddModels.Image = global::ExcelAiAssistant.Properties.Resources.ollama;
            this.tsddModels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddModels.Name = "tsddModels";
            this.tsddModels.Size = new System.Drawing.Size(145, 22);
            this.tsddModels.Text = "请先配置大模型参数";
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 40);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.AutoScroll = true;
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.spcMain.Panel2.Controls.Add(this.txtSendMsg);
            this.spcMain.Panel2.Padding = new System.Windows.Forms.Padding(7);
            this.spcMain.Size = new System.Drawing.Size(491, 545);
            this.spcMain.SplitterDistance = 460;
            this.spcMain.SplitterWidth = 7;
            this.spcMain.TabIndex = 8;
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSendMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSendMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSendMsg.Location = new System.Drawing.Point(7, 7);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(477, 64);
            this.txtSendMsg.TabIndex = 2;
            this.txtSendMsg.Text = "";
            this.txtSendMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendMsg_KeyDown);
            this.txtSendMsg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSendMsg_MouseUp);
            // 
            // menuEdit
            // 
            this.menuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectAll,
            this.tss,
            this.tsmiCopy,
            this.tsmiPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(181, 98);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Image = global::ExcelAiAssistant.Properties.Resources.SelectAll2_16x16;
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(180, 22);
            this.tsmiSelectAll.Text = "全选";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tss
            // 
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = global::ExcelAiAssistant.Properties.Resources.Action_Copy;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopy.Text = "复制";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Image = global::ExcelAiAssistant.Properties.Resources.Paste_16x16;
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(180, 22);
            this.tsmiPaste.Text = "粘贴";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // ChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.barSendMsg);
            this.Controls.Add(this.topBar);
            this.Name = "ChatBox";
            this.Size = new System.Drawing.Size(491, 620);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.barSendMsg.ResumeLayout(false);
            this.barSendMsg.PerformLayout();
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.menuEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip topBar;
        private System.Windows.Forms.ToolStripLabel lbChatTitle;
        private System.Windows.Forms.ToolStripDropDownButton ddbHistory;
        private System.Windows.Forms.ToolStrip barSendMsg;
        private System.Windows.Forms.ToolStripButton btnSendMsg;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.RichTextBox txtSendMsg;
        private System.Windows.Forms.ToolStripProgressBar tspbWaiting;
        private System.Windows.Forms.ContextMenuStrip menuEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripSeparator tss;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripButton tsbNewChat;
        private System.Windows.Forms.ToolStripDropDownButton tsddModels;
    }
}
