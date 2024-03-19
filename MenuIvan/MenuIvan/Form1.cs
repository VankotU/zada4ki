using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuIvan
{
    public partial class Form1 : Form
    {
        string fileName = "unknown";
        public Form1()
        {
            InitializeComponent();
        }

        private void rtb_Click(object sender, EventArgs e)
        {
            wordWrapToolStripMenuItem.Checked = !wordWrapToolStripMenuItem.Checked;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb.Modified)
            {
                DialogResult answer = MessageBox.Show("Do you want to save the changes?", "Prompt"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (answer == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
            }
            rtb.Clear();
            fileName = "unknown file";
            this.Text = "TextPad - " + fileName;
            rtb.Modified = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDLG.Filter = "Text Files|*.txt|Rich Text Files|*.rtf|Word Files|*.docx|All Files|*.*";
            saveDLG.FileName = "";
            saveDLG.Title = "My Text Pad - Save As...";
            saveDLG.FilterIndex = 2;

            if (saveDLG.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            fileName = saveDLG.FileName;
            this.Text = "TextPad - " + saveDLG.FileName;
            if (saveDLG.FilterIndex == 1)
            {
                rtb.SaveFile(saveDLG.FileName, RichTextBoxStreamType.PlainText);
            }
            else if (saveDLG.FilterIndex == 2)
            {
                rtb.SaveFile(saveDLG.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                MessageBox.Show("Unknown Format!");
            }
            rtb.Modified = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb.Modified)
            {
                DialogResult answer = MessageBox.Show("Do you want to save the changes?", "Prompt"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (answer == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
            }
            openDLG.Filter = "Text Files|*.txt|Rich Text Files|*.rtf|Word Files|*.doc;*.docx|All Files|*.*";
            openDLG.FileName = "";
            openDLG.Title = "My Text Pad - Open";
            openDLG.FilterIndex = 2;

            if (openDLG.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            fileName = openDLG.FileName;
            this.Text = "TextPad - " + openDLG.SafeFileName;
            if (openDLG.FilterIndex == 1)
            {
                rtb.LoadFile(openDLG.FileName, RichTextBoxStreamType.PlainText);
            }
            else if (openDLG.FilterIndex == 2)
            {
                rtb.LoadFile(openDLG.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                MessageBox.Show("Unknown Format!");
            }
            rtb.Modified = false;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "unknown")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                rtb.SaveFile(fileName, RichTextBoxStreamType.RichText);
            }
            rtb.Modified = false;
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDLG.ShowColor = true;
            fontDLG.ShowEffects = true;
            fontDLG.ShowApply = true;
            fontDLG.ShowDialog();
            rtb.SelectionFont = fontDLG.Font;
            rtb.SelectionColor = fontDLG.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rtb.Modified == true)
            {
                DialogResult answer = MessageBox.Show("Do you want to save the changes?", "Prompt"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (answer == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                if (answer == DialogResult.Cancel)
                {
                    e.Cancel = true;//stop na subitieto "e"(closing)
                }
            }
        }
    }
}
