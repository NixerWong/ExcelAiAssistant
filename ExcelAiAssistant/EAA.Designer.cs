namespace ExcelAiAssistant
{
    partial class EAA : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EAA()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tbExcelAiAssistant = this.Factory.CreateRibbonTab();
            this.grpEaa = this.Factory.CreateRibbonGroup();
            this.btnShow = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.btnModelConfig = this.Factory.CreateRibbonButton();
            this.grpAbount = this.Factory.CreateRibbonGroup();
            this.btnAbout = this.Factory.CreateRibbonButton();
            this.tbExcelAiAssistant.SuspendLayout();
            this.grpEaa.SuspendLayout();
            this.grpAbount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbExcelAiAssistant
            // 
            this.tbExcelAiAssistant.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tbExcelAiAssistant.Groups.Add(this.grpEaa);
            this.tbExcelAiAssistant.Groups.Add(this.grpAbount);
            this.tbExcelAiAssistant.Label = "Excel AI Assistant";
            this.tbExcelAiAssistant.Name = "tbExcelAiAssistant";
            // 
            // grpEaa
            // 
            this.grpEaa.Items.Add(this.btnShow);
            this.grpEaa.Items.Add(this.separator1);
            this.grpEaa.Items.Add(this.btnModelConfig);
            this.grpEaa.Label = "EAA";
            this.grpEaa.Name = "grpEaa";
            // 
            // btnShow
            // 
            this.btnShow.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnShow.Image = global::ExcelAiAssistant.Properties.Resources.ShowHideComment_32x32;
            this.btnShow.Label = "显示助手";
            this.btnShow.Name = "btnShow";
            this.btnShow.ShowImage = true;
            this.btnShow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShow_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // btnModelConfig
            // 
            this.btnModelConfig.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnModelConfig.Image = global::ExcelAiAssistant.Properties.Resources.Properties_32x32;
            this.btnModelConfig.Label = "模型配置";
            this.btnModelConfig.Name = "btnModelConfig";
            this.btnModelConfig.ShowImage = true;
            this.btnModelConfig.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnModelConfig_Click);
            // 
            // grpAbount
            // 
            this.grpAbount.Items.Add(this.btnAbout);
            this.grpAbount.Name = "grpAbount";
            // 
            // btnAbout
            // 
            this.btnAbout.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAbout.Image = global::ExcelAiAssistant.Properties.Resources.EAA_32;
            this.btnAbout.Label = "关于程序";
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShowImage = true;
            this.btnAbout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAbout_Click);
            // 
            // EAA
            // 
            this.Name = "EAA";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tbExcelAiAssistant);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EAA_Load);
            this.tbExcelAiAssistant.ResumeLayout(false);
            this.tbExcelAiAssistant.PerformLayout();
            this.grpEaa.ResumeLayout(false);
            this.grpEaa.PerformLayout();
            this.grpAbount.ResumeLayout(false);
            this.grpAbount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tbExcelAiAssistant;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpEaa;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShow;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnModelConfig;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpAbount;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAbout;
    }

    partial class ThisRibbonCollection
    {
        internal EAA EAA
        {
            get { return this.GetRibbon<EAA>(); }
        }
    }
}
