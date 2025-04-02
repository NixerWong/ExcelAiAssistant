using ExcelAiAssistant.Components;
using ExcelAiAssistant.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ExcelAiAssistant.Controls
{
    public partial class CodeEditor : UserControl
    {
        public string Code
        {
            get
            {
                return txtCode.Text;
            }
            set
            {
                txtCode.Text = value;
                AdjustHeight();
            }
        }
        public CodeEditor()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            LanguageManager.LanguageChanged += OnLanguageChanged;
            this.OnLanguageChanged();
        }

        private void OnLanguageChanged()
        {
            this.tsmiCopy.Text = Strings.Global_Operation_Copy;
            this.tsbCopy.Text = Strings.Global_Operation_Copy;
            this.tsbCopy.ToolTipText = Strings.Global_Operation_Copy;
            this.tsmiSelectAll.Text = Strings.Global_Operation_SelectAll;

            this.btnSaveCode.Text = Strings.CodeEditor_SaveCode_Text;
            this.btnSaveCode.ToolTipText = Strings.CodeEditor_SaveCode_Text;

            this.btnExec.Text = Strings.CodeEditor_Exec_Text;
            this.btnExec.ToolTipText = Strings.CodeEditor_Exec_Text;
        }

        private void AdjustHeight()
        {
            if (this.txtCode != null)
            {
                //using (Graphics g = this.CreateGraphics())
                //{
                //    // 测量文本的高度
                //    SizeF textSize = g.MeasureString(txtCode.Text, txtCode.Font, this.txtCode.Width);
                //    int h = (int)Math.Ceiling(textSize.Height) + tlpContent.Padding.Top + tlpContent.Padding.Bottom + Padding.Top + Padding.Bottom + barCodeTools.Height + 7; // 2 是边框
                //    Size singleLineSize = TextRenderer.MeasureText("中", txtCode.Font);
                //    //主要是多行时没有考虑行间距
                //    int lineCount = (int)Math.Ceiling(Convert.ToDecimal(textSize.Height) / Convert.ToDecimal((singleLineSize.Height)));
                //    if (lineCount > 1)
                //    {
                //        h += (lineCount - 1) * 2;
                //    }
                //    this.Height = h;
                //}
                // 获取文本的行数
                int lineCount = txtCode.GetLineFromCharIndex(txtCode.TextLength) + 1;

                // 获取每行的高度 加行间距
                int lineHeight = TextRenderer.MeasureText("中", txtCode.Font).Height + 4;

                // 计算控件的高度
                int h = lineCount * lineHeight + tlpContent.Padding.Top + tlpContent.Padding.Bottom + Padding.Top + Padding.Bottom + barCodeTools.Height + 7; // 7 是边框和间距

                this.Height = h;

            }

            CheckRunButtonVisable();
        }

        private void CodeEditor_Load(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void CheckRunButtonVisable()
        {
            if (this.txtCode.Text.Length > 0 && (this.txtCode.Text.ToLower().IndexOf("sub ") >= 0 || this.txtCode.Text.ToLower().IndexOf("function ") >= 0))
            {
                this.btnExec.Visible = true;
                this.tss.Visible = true;
                this.btnSaveCode.Visible = true;
            }
            else
            {
                this.btnExec.Visible = false;
                this.tss.Visible = false;
                this.btnSaveCode.Visible = false;
            }
        }

        private void CodeEditor_SizeChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtCode.Text);
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (this.txtCode.Text != null)
            {
                ExcelVbaExecutor.ExecuteInActiveWorkbook(this.txtCode.Text, true, this.btnSaveCode.Tag == null);
            }
        }

        private void btnSaveCode_Click(object sender, EventArgs e)
        {
            if (this.btnSaveCode.Tag == null)
            {
                this.btnSaveCode.Tag = true;
                this.btnSaveCode.Image = Properties.Resources.CheckBox2_16x16;
            }
            else
            {
                this.btnSaveCode.Tag = null;
                this.btnSaveCode.Image = Properties.Resources.UnCheckBox2_16x16;
            }
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            this.txtCode.SelectAll();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtCode.Text);
        }

        private void txtCode_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuEdit.Show(txtCode, e.Location);
            }
        }

        
    }
}
