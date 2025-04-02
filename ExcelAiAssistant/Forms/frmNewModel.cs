using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelAiAssistant.Languages;

namespace ExcelAiAssistant.Forms
{
    public partial class frmNewModel : Form
    {
        public Models.Config Model { get; set; }
        public bool Changed { get; set; }
        public int NewModelIndex = -1;
        public frmNewModel()
        {
            InitializeComponent();           

            LanguageManager.LanguageChanged += OnLanguageChanged;
            this.OnLanguageChanged();
        }

        private void OnLanguageChanged()
        {
            this.Text = Strings.FormAddNewModel_Caption;
            this.lbModelUrl.Text = Strings.FormAddNewModel_lbBaseUrl;
            this.lbModelName.Text = Strings.FormAddNewModel_lbModelName;
            this.lbAppKey.Text = Strings.FormAddNewModel_lbAppkey;
            this.lbApiType.Text = Strings.FormAddNewModel_lbApiType;
            this.cbEnabled.Text = Strings.FormAddNewModel_cbEnable;
            this.lbSysPrompt.Text = Strings.FormAddNewModel_lbPrompt;
            this.btnSave.Text = "  " + Strings.Global_Operation_Save;

            //this.Font = ThisAddIn.GlobalFont;
            this.txtAppkey.Font = ThisAddIn.GlobalFont;
            this.txtBaseUrl.Font = ThisAddIn.GlobalFont;
            this.txtModelName.Font = ThisAddIn.GlobalFont;
            this.txtSystemPrompt.Font = ThisAddIn.GlobalFont;
            this.ccbApiType.Font = ThisAddIn.GlobalFont;
        }

        public void BindConfig()
        {
            if (Model != null)
            {
                this.txtBaseUrl.Text = Model.BaseUrl;
                this.txtAppkey.Text = Model.AppKey;
                this.txtModelName.Text = Model.ModelName;
                this.ccbApiType.Text = Model.ApiType;
                this.cbEnabled.Checked = (!string.IsNullOrEmpty(Model.Enabled) && Model.Enabled == "Y");
                this.txtSystemPrompt.Text = Model.SystemPrompt;
            }
            else
            {
                this.ccbApiType.SelectedIndex = 0;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                if (Model != null && Model.ModelId > 0)
                {
                    Model.BaseUrl = this.txtBaseUrl.Text;
                    Model.AppKey = this.txtAppkey.Text;
                    Model.ModelName = this.txtModelName.Text;
                    Model.ApiType = this.ccbApiType.Text;
                    Model.Enabled = this.cbEnabled.Checked ? "Y" : "N";
                    Model.SystemPrompt = this.txtSystemPrompt.Text;
                }
                else
                {
                    this.Model = new Models.Config
                    {
                        ModelId = NewModelIndex,
                        BaseUrl = this.txtBaseUrl.Text,
                        AppKey = this.txtAppkey.Text,
                        ModelName = this.txtModelName.Text,
                        ApiType = this.ccbApiType.Text,
                        Enabled = this.cbEnabled.Checked ? "Y" : "N",
                        SystemPrompt = this.txtSystemPrompt.Text

                    };
                }
                this.Changed = true;
                //this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool validateInput()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(this.txtBaseUrl.Text))
            {
                MessageBox.Show(Strings.FormAddNewModel_NoBaseUrl_Error, Strings.Global_Operation_Failure, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBaseUrl.Focus();
                valid = false;
            }

            //this.txtModelName.ErrorText = string.Empty;
            if (string.IsNullOrEmpty(this.txtModelName.Text))
            {
                MessageBox.Show(Strings.FormAddNewModel_NoModelName_Error, Strings.Global_Operation_Failure, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtModelName.Focus();
                valid = false;
            }

            return valid;
        }

        private void frmNewModel_Load(object sender, EventArgs e)
        {
            this.BindConfig();
        }
    }
}
