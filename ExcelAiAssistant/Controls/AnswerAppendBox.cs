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

namespace ExcelAiAssistant.Controls
{
    public partial class AnswerAppendBox : UserControl
    {
        public string Answer
        {
            get
            {
                return this.txtAnswer.Text;
            }
            set
            {
                this.txtAnswer.Text = value;
                AdjustHeight();
            }
        }

        public AnswerAppendBox(Control parent)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.Parent = parent;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            LanguageManager.LanguageChanged += OnLanguageChanged;
            this.OnLanguageChanged();
        }

        private void OnLanguageChanged()
        {
            this.tsmiCopy.Text = Strings.Global_Operation_Copy;
            this.tsmiSelectAll.Text = Strings.Global_Operation_SelectAll;
        }

        private void AdjustHeight()
        {
            if (this.txtAnswer != null)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    // 测量文本的高度
                    SizeF textSize = g.MeasureString(txtAnswer.Text, txtAnswer.Font, txtAnswer.Width);
                    //SizeF textSize = g.MeasureString(txtAnswer.Text, new Font("SimSun",9) , txtAnswer.Width);
                    // 设置 AnswerBox 的高度
                    int h = (int)Math.Ceiling(textSize.Height) + tlpContent.Padding.Top + tlpContent.Padding.Bottom + Padding.Top + Padding.Bottom;
                    Size singleLineSize = TextRenderer.MeasureText("中", txtAnswer.Font);
                    //主要是多行时没有考虑行间距
                    int lineCount = (int)Math.Ceiling(Convert.ToDecimal(textSize.Height) / Convert.ToDecimal((singleLineSize.Height)));
                    if (lineCount > 1)
                    {
                        h += (lineCount - 1) * 1;
                    }
                    this.Height = h;
                }
                //int lineCount = txtAnswer.GetLineFromCharIndex(txtAnswer.TextLength) + 1;

                //// 获取每行的高度 加行间距
                //int lineHeight = TextRenderer.MeasureText("中", txtAnswer.Font).Height + 4;

                //// 计算控件的高度
                //int h = lineCount * lineHeight + tlpContent.Padding.Top + tlpContent.Padding.Bottom + Padding.Top + Padding.Bottom;

                //this.Height = h;
            }
        }

        private void AnswerAppendBox_Load(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void AnswerAppendBox_SizeChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            this.txtAnswer.SelectAll();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtAnswer.SelectedText))
            {
                Clipboard.SetText(this.txtAnswer.SelectedText);
            }
            else
            {
                Clipboard.SetText(this.txtAnswer.Text);
            }
        }

        private void txtAnswer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuEdit.Show(txtAnswer, e.Location);
            }
        }
    }
}
