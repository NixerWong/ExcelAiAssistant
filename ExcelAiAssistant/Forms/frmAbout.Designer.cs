namespace ExcelAiAssistant.Forms
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lbName = new System.Windows.Forms.Label();
            this.lbLink = new System.Windows.Forms.LinkLabel();
            this.ccbLanguage = new System.Windows.Forms.ComboBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(33, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(117, 14);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Excel AI 助手 ";
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Location = new System.Drawing.Point(35, 115);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(275, 12);
            this.lbLink.TabIndex = 4;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "https://github.com/NixerWong/ExcelAiAssistant";
            this.lbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLink_LinkClicked);
            // 
            // ccbLanguage
            // 
            this.ccbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbLanguage.FormattingEnabled = true;
            this.ccbLanguage.Location = new System.Drawing.Point(37, 145);
            this.ccbLanguage.Name = "ccbLanguage";
            this.ccbLanguage.Size = new System.Drawing.Size(142, 20);
            this.ccbLanguage.TabIndex = 5;
            this.ccbLanguage.SelectedIndexChanged += new System.EventHandler(this.ccbLanguage_SelectedIndexChanged);
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(35, 40);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(234, 76);
            this.txtInfo.TabIndex = 6;
            this.txtInfo.Text = "V1.50325\n王珂作品\nhcling97@hotmail.com\n本软件遵循GPL3.0开源协议";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 191);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.ccbLanguage);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.LinkLabel lbLink;
        private System.Windows.Forms.ComboBox ccbLanguage;
        private System.Windows.Forms.RichTextBox txtInfo;
    }
}