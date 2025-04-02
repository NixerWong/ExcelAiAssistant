using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelAiAssistant.Components;
using ExcelAiAssistant.Languages;
using ExcelAiAssistant.Models;

namespace ExcelAiAssistant.Forms
{
    public partial class frmAbout : Form
    {
        Properties.Settings settings = Properties.Settings.Default;
        public frmAbout()
        {
            InitializeComponent();
            BingLangList();

            LanguageManager.LanguageChanged += OnLanguageChanged;
            this.OnLanguageChanged();
        }

        private void BingLangList()
        {
            this.ccbLanguage.Items.Clear();
            this.ccbLanguage.Items.Add(new LangItem() { Lang = "English", Value = "en-US" });
            this.ccbLanguage.Items.Add(new LangItem() { Lang = "简体中文", Value = "zh-CN" });

            if(settings.StartUp_Lang == "en-US")
            {
                this.ccbLanguage.SelectedIndex = 0;
            }
            else
            {
                this.ccbLanguage.SelectedIndex = 1;
            }
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            
        }

        private void OnLanguageChanged()
        {
            // 重新绑定当前窗体的控件文本
            this.Text = Strings.FormAbout_Caption;
            this.lbName.Text = Strings.FormAbout_SysName;
            this.txtInfo.Text = Strings.FormAbout_Info;
            this.lbLink.Text = Strings.FormAbout_Link;

            this.Font = ThisAddIn.GlobalFont;
            this.lbName.Font = ThisAddIn.GlobalFont;            
            this.txtInfo.Font = ThisAddIn.GlobalFont;
            this.lbLink.Font = ThisAddIn.GlobalFont;
        }
        private void lbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.lbLink.Text);
        }

        private void ccbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            LangItem item = this.ccbLanguage.SelectedItem as LangItem;
            LanguageManager.SetLanguage(item.Value);
            settings.StartUp_Lang = item.Value;
            settings.Save();
        }
    }
}
