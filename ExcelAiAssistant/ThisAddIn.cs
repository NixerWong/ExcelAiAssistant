using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using ExcelAiAssistant.Models;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using ExcelAiAssistant.Components;
using System.Drawing;
using Sunny.UI;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Collections;

namespace ExcelAiAssistant
{
    public partial class ThisAddIn
    {
        public static string ConfigFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        }
        //public static ExcelAiAssistant.Controls.ChatBox Box = new Controls.ChatBox();
        //public static Font GlobalFont = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

        public static Font GlobalFont
        {
            get
            {
                Properties.Settings st = new Properties.Settings();
                switch (st.StartUp_Lang)
                {
                    case "zh-CN":
                        return new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                    case "en-US":
                    default:
                        return new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }


        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            try
            {
                Properties.Settings Settings = new Properties.Settings();
                LanguageManager.SetLanguage(Settings.StartUp_Lang);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ThisAddIn_Startup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {            
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
