using ExcelAiAssistant.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelAiAssistant.Components;
using ExcelAiAssistant.Languages;

namespace ExcelAiAssistant.Forms
{
    public partial class frmConfig : Form
    {
        public bool Configed { get; set; } = false;
        private List<Config> configs;
        public frmConfig()
        {
            InitializeComponent();            
            this.BindModelList();

            LanguageManager.LanguageChanged += OnLanguageChanged;
            this.OnLanguageChanged();
        }

        private void RefreshGridView()
        {
            //sunnyui datagridview update datasource will lost colume info, so we need to create a new list
            List<Config> newList = new List<Config>();
            foreach (Config config in configs)
            {
                newList.Add(config);
            }
            this.configs = newList;
            this.gvModels.DataSource = configs;
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmNewModel fnm = new frmNewModel())
                {
                    if(this.configs.Count == 0)
                    {
                        fnm.NewModelIndex = 1;
                    }
                    else
                    {
                        fnm.NewModelIndex = this.configs.Select(c => c.ModelId).Max() + 1;
                    }                    
                    fnm.ShowDialog();
                    if (fnm.Changed)
                    {
                        this.configs.Add(fnm.Model);
                        this.RefreshGridView();
                        this.Configed = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "btnNew_Click");
            }
        }

        private void BindModelList(bool fromConfigfile = false)
        {
            this.configs = ConfigHelper.LoadModelConfigFromFile(ThisAddIn.ConfigFilePath());
            this.gvModels.DataSource = this.configs;
        }

        private void delModel_Click(object sender, EventArgs e)
        {
            this.DeleteModel();     
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            this.DeleteModel();
        }

        private void DeleteModel()
        {
            if (this.gvModels.SelectedRows!=null)
            {
                if (MessageBox.Show(this, Strings.FormModelConfig_btnDelete_Confirm, Strings.Global_Operation_Confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var model = this.gvModels.SelectedRows[0].DataBoundItem as Config;
                    if (model != null)
                    {
                        this.configs.Remove(model);
                        this.RefreshGridView();
                        this.Configed = true;
                    }
                }
            }
        }

        private void gvModels_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditModel();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            this.EditModel();
        }

        private void EditModel()
        {
            if (this.gvModels.SelectedRows != null) 
            {
                var model = this.gvModels.SelectedRows[0].DataBoundItem as Config;
                if (model != null)
                {
                    frmNewModel fnm = new frmNewModel();
                    fnm.Model = model;
                    fnm.ShowDialog();
                    if (fnm.Changed)
                    {
                        this.configs[this.gvModels.SelectedIndex] = model;
                        this.RefreshGridView();
                        this.Configed = true;
                    }
                }
            }
        }


        private void tsbExport_Click(object sender, EventArgs e)
        {
            //导出配置文件
            if (sfdExport.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var outputJson = JsonConvert.SerializeObject(this.configs, Formatting.Indented);
                    File.WriteAllText(sfdExport.FileName, outputJson);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this,ex.Message, Strings.Global_Operation_Failure, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            if (ofdImport.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.configs = ConfigHelper.LoadModelConfigFromFile(ofdImport.FileName);
                    this.RefreshGridView();
                    this.Configed = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, Strings.Global_Operation_Failure, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     

        private void gvModels_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = gvModels.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    gvModels.ClearSelection();
                    gvModels.Rows[hitTestInfo.RowIndex].Selected = true;
                    menuEdit.Show(gvModels, e.Location);
                }
            }
        }

        private void frmConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Configed)
            {
                ConfigHelper.SaveModelConfigToFile(this.configs,ThisAddIn.ConfigFilePath());
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            
        }

        private void OnLanguageChanged()
        {
            // 重新绑定当前窗体的控件文本
            this.Text = Strings.FormModelConfig_Caption;
            this.btnNew.Text = Strings.FormModelConfig_btnAddNew;
            this.btnNew.ToolTipText = Strings.FormModelConfig_btnAddNew;
            this.btnDelModel.Text = Strings.FormModelConfig_btnDelete;
            this.btnDelModel.ToolTipText = Strings.FormModelConfig_btnDelete;
            this.tsbImport.Text = Strings.FormModelConfig_btnImport;
            this.tsbImport.ToolTipText = Strings.FormModelConfig_btnImport;
            this.tsbExport.Text = Strings.FormModelConfig_btnExport;
            this.tsbExport.ToolTipText = Strings.FormModelConfig_btnExport;

            this.tsmiEdit.Text = Strings.Global_Operation_Edit;
            this.tsmiEdit.ToolTipText = Strings.Global_Operation_Edit;
            this.tsmiDelete.Text = Strings.Global_Operation_Delete;
            this.tsmiDelete.ToolTipText = Strings.Global_Operation_Delete;

            this.ofdImport.Title = Strings.FormModelConfig_Import_title;
            this.ofdImport.Filter = Strings.FormModelConfig_Import_filter;

            this.sfdExport.Title = Strings.FormModelConfig_Export_title;
            this.sfdExport.Filter = Strings.FormModelConfig_Export_filter;

            if (this.gvModels?.Columns.Count > 0)
            {
                for (int i = 0; i < this.gvModels.Columns.Count; i++)
                {
                    switch(this.gvModels.Columns[i].Name)
                    {
                        case "colModelName":
                            this.gvModels.Columns[i].HeaderText = Strings.FormModelConfig_colModelName;
                            break;
                        case "colBaseUrl":
                            this.gvModels.Columns[i].HeaderText = Strings.FormModelConfig_colBaseUrl;
                            break;
                        case "colApiType":
                            this.gvModels.Columns[i].HeaderText = Strings.FormModelConfig_colApiType;
                            break;
                        case "colEnabled":
                            this.gvModels.Columns[i].HeaderText = Strings.FormModelConfig_colEnable;
                            break;
                        default:
                            break;
                    }
                }
            }

            this.Font = ThisAddIn.GlobalFont;
            this.gvModels.Font = ThisAddIn.GlobalFont;

        }
    }
}
