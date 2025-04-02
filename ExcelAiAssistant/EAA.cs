using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelAiAssistant.Forms;
using System.Windows.Forms;
using Microsoft.Office.Tools;
using ExcelAiAssistant.Controls;
using ExcelAiAssistant.Languages;
using Sunny.UI.Win32;

using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAiAssistant
{
    public partial class EAA
    {
        private Dictionary<int, CustomTaskPane> aiChatBoxPanes = new Dictionary<int, CustomTaskPane>();

        private void EAA_Load(object sender, RibbonUIEventArgs e)
        {
            try
            {
                var activeWindow = Globals.ThisAddIn.Application.ActiveWindow;
                if (activeWindow != null)
                {
                    AddCustomTaskPaneForWindow(activeWindow);
                }

                ((Excel.AppEvents_Event)Globals.ThisAddIn.Application).NewWorkbook += Application_NewWorkbook;
                ((Excel.AppEvents_Event)Globals.ThisAddIn.Application).WorkbookOpen += Application_WorkbookOpen;
                ((Excel.AppEvents_Event)Globals.ThisAddIn.Application).WindowActivate += Application_WindowActivate;
                ((Excel.AppEvents_Event)Globals.ThisAddIn.Application).WorkbookBeforeClose += Application_WorkbookBeforeClose;

                LanguageManager.LanguageChanged += OnLanguageChanged;
                this.OnLanguageChanged();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EAA_Load");
            }
            
        }
        private void Application_NewWorkbook(Excel.Workbook Wb)
        {
            AddCustomTaskPaneForWindow(Wb.Windows[1]);
        }

        private void Application_WorkbookOpen(Excel.Workbook Wb)
        {
            AddCustomTaskPaneForWindow(Wb.Windows[1]);
        }

        private void Application_WindowActivate(Excel.Workbook Wb, Excel.Window Wn)
        {
            if (!aiChatBoxPanes.ContainsKey(Wn.Hwnd))
            {
                AddCustomTaskPaneForWindow(Wn);
            }
        }

        private void Application_WorkbookBeforeClose(Excel.Workbook Wb, ref bool Cancel)
        {
            foreach (Excel.Window window in Wb.Windows)
            {
                if (aiChatBoxPanes.ContainsKey(window.Hwnd))
                {
                    var pane = aiChatBoxPanes[window.Hwnd];
                    var chatBox = pane.Control as ChatBox;
                    if (chatBox != null)
                    {
                        chatBox.SaveAndCleanConversation();
                    }
                    aiChatBoxPanes.Remove(window.Hwnd);
                }
            }
        }

        private void AddCustomTaskPaneForWindow(Excel.Window window)
        {
            var chatBox = new ChatBox(); // Create a new instance of ChatBox for each window
            var customTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(chatBox, Strings.RibbonTab_Title, window);
            customTaskPane.Width = 400;
            customTaskPane.Visible = false;
            aiChatBoxPanes[window.Hwnd] = customTaskPane;
        }

        private void OnLanguageChanged()
        {
            // 重新绑定当前窗体的控件文本
            this.tbExcelAiAssistant.Label = Strings.RibbonTab_Title;
            this.btnShow.Label = Strings.RibbonBtn_OpenBox;
            this.btnModelConfig.Label = Strings.RibbonBtn_ModelConfig;
            this.btnAbout.Label = Strings.RibbonBtn_About;
        }

        private void btnShow_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                var activeWindow = Globals.ThisAddIn.Application.ActiveWindow;
                if (activeWindow != null)
                {
                    if (aiChatBoxPanes.ContainsKey(activeWindow.Hwnd))
                    {
                        var pane = aiChatBoxPanes[activeWindow.Hwnd];
                        pane.Visible = !pane.Visible;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                using (frmAbout about = new frmAbout())
                {
                    about.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModelConfig_Click(object sender, RibbonControlEventArgs e)
        {
            using (frmConfig cfg = new frmConfig())
            {
                cfg.ShowDialog();
                if (cfg.Configed)
                {
                    foreach (var pane in aiChatBoxPanes.Values)
                    {
                        var chatBox = pane.Control as ChatBox;
                        if (chatBox != null)
                        {
                            chatBox.LoadModelConfig();
                            chatBox.SaveAndCleanConversation();
                            chatBox.InitDefaultChat();
                        }
                    }
                }
            }
        }
    }
}
