using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using VBIDE = Microsoft.Vbe.Interop;
using ExcelAiAssistant.Languages;


namespace ExcelAiAssistant.Components
{
    public static class ExcelVbaExecutor
    {

        #region Execute VBA Code
        public static void ExecuteVbaCode(Excel.Workbook workbook, string vbaCode, bool showErrors = true, bool clearEnv = true)
        {
            if (workbook == null) throw new ArgumentNullException(nameof(workbook));

            VBIDE.VBComponent tempModule = null;
            string macroName = null;

            try
            {
                string dupCode = vbaCode;
                macroName = ExtractMacroName(ref dupCode);

                if(string.IsNullOrEmpty(macroName))
                {
                    throw new InvalidOperationException(Strings.Component_DontComplyStandard);
                }

                // 获取VBA工程对象
                var vbProject = workbook.VBProject;

                // 创建临时模块
                tempModule = vbProject.VBComponents.Add(VBIDE.vbext_ComponentType.vbext_ct_StdModule);
                

                // 将代码转换为UTF-8编码格式
                byte[] utf8Bytes = Encoding.UTF8.GetBytes(dupCode);
                byte[] defaultBytes = Encoding.Convert(Encoding.UTF8, Encoding.Default, utf8Bytes);
                string defaultString = Encoding.Default.GetString(defaultBytes);

                // 插入代码到模块
                tempModule.CodeModule.AddFromString(defaultString);


                // 执行宏
                (workbook.Application).Run(macroName);

            }
            catch (Exception ex)
            {
                if (showErrors)
                {
                    MessageBox.Show(
                        Strings.Component_Exec_Error + ex.Message,
                        Strings.Global_Operation_Failure,
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            finally
            {
                // 清理临时模块
                if (clearEnv && tempModule != null)
                {
                    try
                    {
                        var vbProject = workbook.VBProject;
                        vbProject.VBComponents.Remove(tempModule);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(Strings.Component_Clean_Error + ex.Message);
                    }
                }

            }
        }

        public static void ExecuteInActiveWorkbook(string vbaCode, bool showErrors = true ,bool clearEnv = true)
        {
            try
            {
                var app = Globals.ThisAddIn?.Application;
                if (app == null || !Marshal.IsComObject(app)) throw new InvalidOperationException(Strings.Component_Excel_NotAvailable);

                //先添加字典引用
                ExcelVbaExecutor.AddDictionaryReference();

                //MessageBox.Show(app.ActiveWorkbook.Sheets.Count.ToString());
                ExecuteVbaCode(app.ActiveWorkbook, vbaCode, showErrors,clearEnv);
            }
            catch (Exception ex)
            {
                if (showErrors)
                {
                    MessageBox.Show(
                        Strings.Component_Exec_Error + ex.Message,
                        Strings.Global_Operation_Failure,
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }

        private static string ExtractMacroName(ref string vbaCode, bool makeGuidName = true)
        {
            string[] lines = vbaCode.Split('\n');
            string dupCode = string.Empty;
            string macroName = string.Empty;
            string guidName = string.Empty;
            foreach (var line in lines)
            {
                var match = Regex.Match(line, @"\b(Sub|Function)\s+(\w+)\s*\(.*$", RegexOptions.IgnoreCase);
                if (match.Success && string.IsNullOrEmpty(macroName))
                {
                    macroName = match.Groups[2].Value.Trim();
                    if (makeGuidName)
                    {
                        guidName = macroName + "_" + Guid.NewGuid().ToString("N").Substring(0, 8);
                        dupCode += line.Replace(macroName, guidName) + "\n";
                    }
                    else
                    {
                        //只要名字就直接返回名字，源码也不需要修改
                        return macroName;
                    }
                }
                else
                {
                    dupCode += line + "\n";
                }
            }

            vbaCode = dupCode;
            return guidName;
        }


        #endregion

        #region Auxiliary Methods
        public static void AddDictionaryReference()
        {
            try
            {                //重复执行会失败

                var app = Globals.ThisAddIn?.Application;
                if (app == null || !Marshal.IsComObject(app)) throw new InvalidOperationException(Strings.Component_Excel_NotAvailable);
                var references = app.ActiveWorkbook.VBProject.References;
                bool hasDictRef = false;
                foreach (VBIDE.Reference reference in references)
                {
                    if (reference.Name == "Scripting")
                    {
                        hasDictRef = true;
                        break;
                    }
                }
                if (!hasDictRef)
                {
                    references.AddFromGuid("{420B2830-E718-11CF-893D-00A0C9054228}", 1, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Strings.Component_Reference_Dict_Error + Environment.NewLine + ex.Message, Strings.Global_Operation_Failure, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }


}
