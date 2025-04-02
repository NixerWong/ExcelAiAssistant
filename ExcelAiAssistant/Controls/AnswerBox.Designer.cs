namespace ExcelAiAssistant.Controls
{
    partial class AnswerBox
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
            this.barTitle = new System.Windows.Forms.ToolStrip();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.menuEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCaption = new System.Windows.Forms.ToolStripLabel();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.barTitle.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.menuEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // barTitle
            // 
            this.barTitle.AutoSize = false;
            this.barTitle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCaption});
            this.barTitle.Location = new System.Drawing.Point(0, 0);
            this.barTitle.Name = "barTitle";
            this.barTitle.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.barTitle.Size = new System.Drawing.Size(463, 30);
            this.barTitle.Stretch = true;
            this.barTitle.TabIndex = 0;
            this.barTitle.Text = "Answer";
            // 
            // tlpContent
            // 
            this.tlpContent.BackColor = System.Drawing.Color.Transparent;
            this.tlpContent.ColumnCount = 1;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Controls.Add(this.txtAnswer, 0, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 30);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(5);
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Size = new System.Drawing.Size(463, 152);
            this.tlpContent.TabIndex = 1;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnswer.Location = new System.Drawing.Point(5, 5);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(0);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(453, 142);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.Text = "";
            this.txtAnswer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtAnswer_MouseUp);
            // 
            // menuEdit
            // 
            this.menuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectAll,
            this.tsmiCopy});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = global::ExcelAiAssistant.Properties.Resources.Action_Copy;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(100, 22);
            this.tsmiCopy.Text = "复制";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // lbCaption
            // 
            this.lbCaption.Image = global::ExcelAiAssistant.Properties.Resources.bot_small;
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(101, 27);
            this.lbCaption.Text = " Excel AI 助手";
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Image = global::ExcelAiAssistant.Properties.Resources.SelectAll2_16x161;
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(100, 22);
            this.tsmiSelectAll.Text = "全选";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // AnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tlpContent);
            this.Controls.Add(this.barTitle);
            this.Name = "AnswerBox";
            this.Size = new System.Drawing.Size(463, 182);
            this.Load += new System.EventHandler(this.AnswerBox_Load);
            this.SizeChanged += new System.EventHandler(this.AnswerBox_SizeChanged);
            this.barTitle.ResumeLayout(false);
            this.barTitle.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.menuEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip barTitle;
        private System.Windows.Forms.ToolStripLabel lbCaption;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private System.Windows.Forms.ContextMenuStrip menuEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
    }
}
