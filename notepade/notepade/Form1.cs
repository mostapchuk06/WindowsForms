using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace notepade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SaveToolStrip_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.O))
            {
                OpenToolStrip_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.C))
            {
                CopyToolStrip_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.V))
            {
                PasteToolStrip_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.X))
            {
                CutToolStrip_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.A))
            {
                SelectToolStrip_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Space))
            {
                DeselectToolStrip_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void TextColorToolStrip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new();
            dialog.Color = richTextBox1.ForeColor;
            if (dialog.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = dialog.Color;
        }
        private void TextStyleToolStrip_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                FontDialog dialog = new();
                dialog.Font = richTextBox1.SelectionFont;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = dialog.Font;
                }
            }
        }
        private void SaveToolStrip_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new();
            save.DefaultExt = ".rtf";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (save.ShowDialog() == DialogResult.OK)
                File.WriteAllText(save.FileName, richTextBox1.Text);

        }
        private void OpenToolStrip_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.Filter = "Text Files|*.rtf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(save.FileName);
                richTextBox1.Text = content;
            }
        }
        private void CopyToolStrip_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }
        private void PasteToolStrip_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() != "")
            {
                richTextBox1.SelectedText = Clipboard.GetText();
            }
        }
        private void CutToolStrip_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.SelectedText = "";
            }
        }
        private void SelectToolStrip_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();
        }
        private void DeselectToolStrip_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionLength = 0;
        }
        private void BackgroundColorToolStrip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = dialog.Color;
            }
        }

        private void BulletedListToolStrip_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 20;
            richTextBox1.SelectionHangingIndent = -15;
        }
        private void AlignLeftToolStrip_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlignCenterToolStrip_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }     
        private void AlignRightToolStrip_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}