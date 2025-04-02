namespace ExcelAiAssistant.Controls
{
    partial class CodeEditor
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
            this.plContent = new Sunny.UI.UIPanel();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.barCodeTools = new System.Windows.Forms.ToolStrip();
            this.lbInfo = new System.Windows.Forms.ToolStripLabel();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.btnExec = new System.Windows.Forms.ToolStripButton();
            this.tss = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveCode = new System.Windows.Forms.ToolStripButton();
            this.menuEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.plContent.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.barCodeTools.SuspendLayout();
            this.menuEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.Transparent;
            this.plContent.Controls.Add(this.tlpContent);
            this.plContent.Controls.Add(this.barCodeTools);
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.FillColor = System.Drawing.Color.Transparent;
            this.plContent.FillColor2 = System.Drawing.Color.Transparent;
            this.plContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plContent.Location = new System.Drawing.Point(10, 2);
            this.plContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plContent.MinimumSize = new System.Drawing.Size(1, 1);
            this.plContent.Name = "plContent";
            this.plContent.Padding = new System.Windows.Forms.Padding(1);
            this.plContent.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.plContent.RectColor = System.Drawing.SystemColors.ControlDark;
            this.plContent.Size = new System.Drawing.Size(525, 298);
            this.plContent.TabIndex = 0;
            this.plContent.Text = null;
            this.plContent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 1;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Controls.Add(this.txtCode, 0, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(1, 1);
            this.tlpContent.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(5);
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContent.Size = new System.Drawing.Size(523, 266);
            this.tlpContent.TabIndex = 9;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.Location = new System.Drawing.Point(5, 5);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(513, 256);
            this.txtCode.TabIndex = 5;
            this.txtCode.Text = "";
            this.txtCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtCode_MouseUp);
            // 
            // barCodeTools
            // 
            this.barCodeTools.AutoSize = false;
            this.barCodeTools.BackColor = System.Drawing.SystemColors.ControlLight;
            this.barCodeTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barCodeTools.GripMargin = new System.Windows.Forms.Padding(0);
            this.barCodeTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barCodeTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbInfo,
            this.tsbCopy,
            this.btnExec,
            this.tss,
            this.btnSaveCode});
            this.barCodeTools.Location = new System.Drawing.Point(1, 267);
            this.barCodeTools.Name = "barCodeTools";
            this.barCodeTools.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.barCodeTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.barCodeTools.Size = new System.Drawing.Size(523, 30);
            this.barCodeTools.TabIndex = 8;
            this.barCodeTools.Text = "代码工具栏";
            // 
            // lbInfo
            // 
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 27);
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Image = global::ExcelAiAssistant.Properties.Resources.Action_Copy;
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(23, 27);
            this.tsbCopy.Text = "复制代码";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // btnExec
            // 
            this.btnExec.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExec.Image = global::ExcelAiAssistant.Properties.Resources.Action_SimpleAction;
            this.btnExec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(52, 27);
            this.btnExec.Text = "执行";
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // tss
            // 
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(6, 30);
            // 
            // btnSaveCode
            // 
            this.btnSaveCode.Image = global::ExcelAiAssistant.Properties.Resources.UnCheckBox2_16x16;
            this.btnSaveCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCode.Name = "btnSaveCode";
            this.btnSaveCode.Size = new System.Drawing.Size(141, 27);
            this.btnSaveCode.Text = "将代码保存在Excel中";
            this.btnSaveCode.Click += new System.EventHandler(this.btnSaveCode_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectAll,
            this.tsmiCopy});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Image = global::ExcelAiAssistant.Properties.Resources.SelectAll2_16x16;
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(100, 22);
            this.tsmiSelectAll.Text = "全选";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = global::ExcelAiAssistant.Properties.Resources.Action_Copy;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(100, 22);
            this.tsmiCopy.Text = "复制";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // CodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.plContent);
            this.DoubleBuffered = true;
            this.Name = "CodeEditor";
            this.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.Size = new System.Drawing.Size(545, 302);
            this.Load += new System.EventHandler(this.CodeEditor_Load);
            this.SizeChanged += new System.EventHandler(this.CodeEditor_SizeChanged);
            this.plContent.ResumeLayout(false);
            this.tlpContent.ResumeLayout(false);
            this.barCodeTools.ResumeLayout(false);
            this.barCodeTools.PerformLayout();
            this.menuEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel plContent;
        private System.Windows.Forms.ToolStrip barCodeTools;
        private System.Windows.Forms.ToolStripLabel lbInfo;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton btnExec;
        private System.Windows.Forms.ToolStripSeparator tss;
        private System.Windows.Forms.ToolStripButton btnSaveCode;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.ContextMenuStrip menuEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
    }
}
