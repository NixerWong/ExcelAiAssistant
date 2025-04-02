namespace ExcelAiAssistant.Forms
{
    partial class frmNewModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewModel));
            this.lbModelUrl = new System.Windows.Forms.Label();
            this.lbModelName = new System.Windows.Forms.Label();
            this.lbAppKey = new System.Windows.Forms.Label();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.lbApiType = new System.Windows.Forms.Label();
            this.lbSysPrompt = new System.Windows.Forms.Label();
            this.btnSave = new Sunny.UI.UIImageButton();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtAppkey = new System.Windows.Forms.TextBox();
            this.ccbApiType = new System.Windows.Forms.ComboBox();
            this.txtSystemPrompt = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // lbModelUrl
            // 
            this.lbModelUrl.AutoSize = true;
            this.lbModelUrl.Location = new System.Drawing.Point(23, 24);
            this.lbModelUrl.Name = "lbModelUrl";
            this.lbModelUrl.Size = new System.Drawing.Size(65, 12);
            this.lbModelUrl.TabIndex = 0;
            this.lbModelUrl.Text = "接口地址：";
            // 
            // lbModelName
            // 
            this.lbModelName.AutoSize = true;
            this.lbModelName.Location = new System.Drawing.Point(23, 60);
            this.lbModelName.Name = "lbModelName";
            this.lbModelName.Size = new System.Drawing.Size(65, 12);
            this.lbModelName.TabIndex = 0;
            this.lbModelName.Text = "模型名称：";
            // 
            // lbAppKey
            // 
            this.lbAppKey.AutoSize = true;
            this.lbAppKey.Location = new System.Drawing.Point(23, 95);
            this.lbAppKey.Name = "lbAppKey";
            this.lbAppKey.Size = new System.Drawing.Size(65, 12);
            this.lbAppKey.TabIndex = 0;
            this.lbAppKey.Text = "访问密钥：";
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(246, 131);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(84, 16);
            this.cbEnabled.TabIndex = 5;
            this.cbEnabled.Text = "启用该模型";
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // lbApiType
            // 
            this.lbApiType.AutoSize = true;
            this.lbApiType.Location = new System.Drawing.Point(23, 131);
            this.lbApiType.Name = "lbApiType";
            this.lbApiType.Size = new System.Drawing.Size(65, 12);
            this.lbApiType.TabIndex = 0;
            this.lbApiType.Text = "接口类型：";
            // 
            // lbSysPrompt
            // 
            this.lbSysPrompt.AutoSize = true;
            this.lbSysPrompt.Location = new System.Drawing.Point(23, 168);
            this.lbSysPrompt.Name = "lbSysPrompt";
            this.lbSysPrompt.Size = new System.Drawing.Size(65, 12);
            this.lbSysPrompt.TabIndex = 0;
            this.lbSysPrompt.Text = "提 示 词：";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Image = global::ExcelAiAssistant.Properties.Resources.Save_16x16;
            this.btnSave.ImageLocation = "";
            this.btnSave.ImageOffset = new System.Drawing.Point(15, 5);
            this.btnSave.Location = new System.Drawing.Point(249, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "   保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(91, 21);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(240, 21);
            this.txtBaseUrl.TabIndex = 9;
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(91, 57);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(240, 21);
            this.txtModelName.TabIndex = 9;
            // 
            // txtAppkey
            // 
            this.txtAppkey.Location = new System.Drawing.Point(91, 92);
            this.txtAppkey.Name = "txtAppkey";
            this.txtAppkey.Size = new System.Drawing.Size(240, 21);
            this.txtAppkey.TabIndex = 9;
            // 
            // ccbApiType
            // 
            this.ccbApiType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbApiType.FormattingEnabled = true;
            this.ccbApiType.Items.AddRange(new object[] {
            "Ollama Type",
            "OpenAI Type",
            "Http Type"});
            this.ccbApiType.Location = new System.Drawing.Point(91, 127);
            this.ccbApiType.Name = "ccbApiType";
            this.ccbApiType.Size = new System.Drawing.Size(131, 20);
            this.ccbApiType.TabIndex = 10;
            // 
            // txtSystemPrompt
            // 
            this.txtSystemPrompt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSystemPrompt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSystemPrompt.Location = new System.Drawing.Point(91, 163);
            this.txtSystemPrompt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSystemPrompt.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSystemPrompt.Multiline = true;
            this.txtSystemPrompt.Name = "txtSystemPrompt";
            this.txtSystemPrompt.Padding = new System.Windows.Forms.Padding(7);
            this.txtSystemPrompt.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.txtSystemPrompt.RectColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSystemPrompt.ScrollBarColor = System.Drawing.Color.Silver;
            this.txtSystemPrompt.ScrollBarStyleInherited = false;
            this.txtSystemPrompt.ShowText = false;
            this.txtSystemPrompt.Size = new System.Drawing.Size(240, 108);
            this.txtSystemPrompt.TabIndex = 11;
            this.txtSystemPrompt.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtSystemPrompt.Watermark = "";
            // 
            // frmNewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 334);
            this.Controls.Add(this.txtSystemPrompt);
            this.Controls.Add(this.ccbApiType);
            this.Controls.Add(this.txtAppkey);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.txtBaseUrl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.lbAppKey);
            this.Controls.Add(this.lbModelName);
            this.Controls.Add(this.lbSysPrompt);
            this.Controls.Add(this.lbApiType);
            this.Controls.Add(this.lbModelUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增模型";
            this.Load += new System.EventHandler(this.frmNewModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModelUrl;
        private System.Windows.Forms.Label lbModelName;
        private System.Windows.Forms.Label lbAppKey;
        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.Label lbApiType;
        private System.Windows.Forms.Label lbSysPrompt;
        private Sunny.UI.UIImageButton btnSave;
        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtAppkey;
        private System.Windows.Forms.ComboBox ccbApiType;
        private Sunny.UI.UITextBox txtSystemPrompt;
    }
}