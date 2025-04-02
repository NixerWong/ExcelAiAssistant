namespace ExcelAiAssistant.Forms
{
    partial class frmConfig
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.toolStripConfig = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.menuEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.gvModels = new Sunny.UI.UIDataGridView();
            this.btnDelModel = new System.Windows.Forms.ToolStripButton();
            this.colModelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAppKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApiType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystemPrompt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripConfig.SuspendLayout();
            this.menuEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvModels)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripConfig
            // 
            this.toolStripConfig.AutoSize = false;
            this.toolStripConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnDelModel,
            this.tss1,
            this.tsbImport,
            this.tsbExport});
            this.toolStripConfig.Location = new System.Drawing.Point(0, 0);
            this.toolStripConfig.Name = "toolStripConfig";
            this.toolStripConfig.Size = new System.Drawing.Size(696, 30);
            this.toolStripConfig.TabIndex = 0;
            this.toolStripConfig.Text = "配置信息";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::ExcelAiAssistant.Properties.Resources.Add_16x16;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 27);
            this.btnNew.Text = "添加新模型";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbImport
            // 
            this.tsbImport.AutoSize = false;
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Image = global::ExcelAiAssistant.Properties.Resources.Upload_16x16;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(27, 27);
            this.tsbImport.Text = "导入参数";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.AutoSize = false;
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = global::ExcelAiAssistant.Properties.Resources.SaveAndNew_16x16;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(27, 27);
            this.tsbExport.Text = "导出参数";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = global::ExcelAiAssistant.Properties.Resources.Action_Edit;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(100, 22);
            this.tsmiEdit.Text = "修改";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = global::ExcelAiAssistant.Properties.Resources.Action_Delete;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // ofdImport
            // 
            this.ofdImport.FileName = "modelConfigs";
            this.ofdImport.Filter = "Json 文件|*.json";
            this.ofdImport.Title = "请选择需要导入的参数文件";
            // 
            // sfdExport
            // 
            this.sfdExport.Filter = "Json 文件|*.json";
            this.sfdExport.Title = "导出参数配置";
            // 
            // gvModels
            // 
            this.gvModels.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvModels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvModels.BackgroundColor = System.Drawing.Color.White;
            this.gvModels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvModels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvModels.ColumnHeadersHeight = 25;
            this.gvModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colModelId,
            this.colModelName,
            this.colBaseUrl,
            this.colAppKey,
            this.colApiType,
            this.colEnabled,
            this.colSystemPrompt});
            this.gvModels.ContextMenuStrip = this.menuEdit;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvModels.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvModels.EnableHeadersVisualStyles = false;
            this.gvModels.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gvModels.GridColor = System.Drawing.Color.Silver;
            this.gvModels.Location = new System.Drawing.Point(0, 30);
            this.gvModels.Name = "gvModels";
            this.gvModels.ReadOnly = true;
            this.gvModels.RectColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvModels.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvModels.RowHeadersWidth = 20;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray;
            this.gvModels.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvModels.RowTemplate.Height = 23;
            this.gvModels.ScrollBarColor = System.Drawing.SystemColors.ControlLight;
            this.gvModels.ScrollBarRectColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvModels.ScrollBarStyleInherited = false;
            this.gvModels.SelectedIndex = -1;
            this.gvModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvModels.Size = new System.Drawing.Size(696, 247);
            this.gvModels.StripeOddColor = System.Drawing.Color.White;
            this.gvModels.TabIndex = 1;
            this.gvModels.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvModels_CellDoubleClick);
            this.gvModels.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvModels_MouseDown);
            // 
            // btnDelModel
            // 
            this.btnDelModel.Image = global::ExcelAiAssistant.Properties.Resources.Action_Delete;
            this.btnDelModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelModel.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
            this.btnDelModel.Name = "btnDelModel";
            this.btnDelModel.Size = new System.Drawing.Size(76, 27);
            this.btnDelModel.Text = "删除模型";
            this.btnDelModel.Click += new System.EventHandler(this.delModel_Click);
            // 
            // colModelId
            // 
            this.colModelId.DataPropertyName = "ModelId";
            this.colModelId.FillWeight = 90F;
            this.colModelId.HeaderText = "ID";
            this.colModelId.Name = "colModelId";
            this.colModelId.ReadOnly = true;
            this.colModelId.Visible = false;
            // 
            // colModelName
            // 
            this.colModelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colModelName.DataPropertyName = "ModelName";
            this.colModelName.HeaderText = "模型名称";
            this.colModelName.Name = "colModelName";
            this.colModelName.ReadOnly = true;
            this.colModelName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colModelName.Width = 160;
            // 
            // colBaseUrl
            // 
            this.colBaseUrl.DataPropertyName = "BaseUrl";
            this.colBaseUrl.FillWeight = 93.27411F;
            this.colBaseUrl.HeaderText = "接口地址";
            this.colBaseUrl.Name = "colBaseUrl";
            this.colBaseUrl.ReadOnly = true;
            // 
            // colAppKey
            // 
            this.colAppKey.DataPropertyName = "AppKey";
            this.colAppKey.FillWeight = 93.27411F;
            this.colAppKey.HeaderText = "访问密钥";
            this.colAppKey.Name = "colAppKey";
            this.colAppKey.ReadOnly = true;
            this.colAppKey.Visible = false;
            // 
            // colApiType
            // 
            this.colApiType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colApiType.DataPropertyName = "ApiType";
            this.colApiType.HeaderText = "接口类型";
            this.colApiType.Name = "colApiType";
            this.colApiType.ReadOnly = true;
            this.colApiType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEnabled
            // 
            this.colEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEnabled.DataPropertyName = "Enabled";
            this.colEnabled.HeaderText = "启用";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.ReadOnly = true;
            this.colEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEnabled.Width = 50;
            // 
            // colSystemPrompt
            // 
            this.colSystemPrompt.DataPropertyName = "SystemPrompt";
            this.colSystemPrompt.HeaderText = "系统提示词";
            this.colSystemPrompt.Name = "colSystemPrompt";
            this.colSystemPrompt.ReadOnly = true;
            this.colSystemPrompt.Visible = false;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 277);
            this.Controls.Add(this.gvModels);
            this.Controls.Add(this.toolStripConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模型设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfig_FormClosing);
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.toolStripConfig.ResumeLayout(false);
            this.toolStripConfig.PerformLayout();
            this.menuEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvModels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripConfig;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ContextMenuStrip menuEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private Sunny.UI.UIDataGridView gvModels;
        private System.Windows.Forms.ToolStripButton btnDelModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApiType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystemPrompt;
    }
}