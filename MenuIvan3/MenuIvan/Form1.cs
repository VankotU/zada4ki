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
        private string fileName = "";
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
                if (answer == DialogResult.Cancel)
                {
                    return;
                }
            }
            rtb.Clear();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDLG.Filter = "All Files|*.*|Text Files|*.txt|Word Files|*.doc|RTF Files|*.rtf";
            saveDLG.Title = "My Text Pad - Save As...";
            saveDLG.FilterIndex = 2;
            saveDLG.InitialDirectory = Application.ExecutablePath;
            saveDLG.DefaultExt = ".txt";

            if (saveDLG.ShowDialog() == DialogResult.OK)
            {
                rtb.SaveFile(saveDLG.FileName, RichTextBoxStreamType.RichText);
                setFileTitle(saveDLG.FileName);
                fileName = saveDLG.FileName;
            }
        }

        private void setFileTitle(string a)
        {
            System.IO.FileInfo fn = new System.IO.FileInfo(a);
            this.Text = fn.Name + "Text Editor";
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
                if (answer == DialogResult.Cancel)
                {
                    return;
                }
            }
            openDLG.Filter = "All Files|*.*|Text Files|*.txt|Word Files|*.doc|RTF Files|*.rtf";
            openDLG.InitialDirectory = Application.StartupPath+"\\Files";
            if (openDLG.ShowDialog() == DialogResult.OK)
            {
                rtb.LoadFile(openDLG.FileName, RichTextBoxStreamType.PlainText);
                setFileTitle(openDLG.FileName);
                fileName = openDLG.FileName;
            }
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
            if (openDLG.FileName == "" && saveDLG.FileName == "")
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            else 
            {
                if (openDLG.FileName != "")
                {
                    rtb.SaveFile(openDLG.FileName, RichTextBoxStreamType.RichText);
                }
                if (saveDLG.FileName != "")
                {
                    rtb.SaveFile(saveDLG.FileName, RichTextBoxStreamType.RichText);
                }
            }
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
            if (rtb.Modified)
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
                    return;
                }
            }
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
