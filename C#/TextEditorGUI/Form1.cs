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
using System.Drawing.Text;
using System.Runtime.Remoting.Channels;
using System.Drawing.Printing;

namespace TextEditorGUI
{
    public partial class Form1 : Form
    {

        string savedPath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.Font = new Font("Consolas", 12, FontStyle.Regular);
            

            newToolStripMenuItem.Click += (sender, EventArgs) => { OnNew(sender, EventArgs); };
            openToolStripMenuItem.Click += (sender, EventArgs) => { OnOpen(sender, EventArgs); };
            saveToolStripMenuItem.Click += (sender, EventArgs) => { OnSave(sender, EventArgs); };
            saveAsToolStripMenuItem.Click += (sender, EventArgs) => { OnSaveAs(sender, EventArgs); };
            exitToolStripMenuItem.Click += (sender, EventArgs) => { OnExit(sender, EventArgs); };
            undoToolStripMenuItem.Click += (sender, EventArgs) => { OnUndo(sender, EventArgs); };
            redoToolStripMenuItem.Click += (sender, EventArgs) => { OnRedo(sender, EventArgs); };
            fontToolStripMenuItem.Click += (sender, EventArgs) => { OnFont(sender, EventArgs); };
            textBoxBackgroundColorToolStripMenuItem.Click += (sender, EventArgs) => { OnMenustripColor(sender, EventArgs); };
            lightModeToolStripMenuItem.Click += (sender, EventArgs) => { OnMenustripColor(sender, EventArgs); };
            darkModeToolStripMenuItem.Click += (sender, EventArgs) => { OnMenustripColor(sender, EventArgs); };
            fontToolStripMenuItem1.Click += (sender, EventArgs) => { OnThemeFont(sender, EventArgs); };
            texteditorBackgroundToolStripMenuItem.Click += (sender, EventArgs) => { OnMenustripColor2(sender, EventArgs); };
        }

        private void OnNew(object sender, EventArgs e)
        {
            if (savedPath == string.Empty)
            {
                OnSaveAs(sender, e);
            }
            else
            {
                OnSave(sender, e);
            }

            richTextBox1.Text = string.Empty;
            savedPath = string.Empty;
        }

        private void OnSaveAs(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    savedPath = saveFileDialog1.FileName;
                    File.WriteAllText(savedPath, richTextBox1.Text);
                }
            }
        }

        private void OnSave(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (savedPath != string.Empty)
                {
                    File.WriteAllText(savedPath, richTextBox1.Text);
                }
                else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    savedPath = saveFileDialog1.FileName;
                    File.WriteAllText(savedPath, richTextBox1.Text);
                }
            }
        }

        private void OnOpen(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog1.FileName;
                    savedPath = openFileDialog1.FileName;
                    richTextBox1.Text = (File.ReadAllText(filePath));

                }
            }
        }
        private void OnExit(object sender, EventArgs e)
        {
            if(savedPath == string.Empty && richTextBox1.TextLength != 0)
            {
                OnSaveAs(sender, e);
            } else if (savedPath != string.Empty && richTextBox1.TextLength != 0)
            {
                OnSave(sender, e);
            }

            System.Windows.Forms.Application.Exit();
        }

        private void OnUndo(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void OnRedo(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void OnFont(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color = richTextBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void OnMenustripColor (object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.ShowHelp = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.BackColor = colorDialog1.Color;
                newToolStripMenuItem.BackColor = colorDialog1.Color;
                openToolStripMenuItem.BackColor = colorDialog1.Color;
                saveToolStripMenuItem.BackColor = colorDialog1.Color;
                saveAsToolStripMenuItem.BackColor = colorDialog1.Color;
                exitToolStripMenuItem.BackColor = colorDialog1.Color;
                undoToolStripMenuItem.BackColor = colorDialog1.Color;
                redoToolStripMenuItem.BackColor = colorDialog1.Color;
                fontToolStripMenuItem.BackColor = colorDialog1.Color;
                colorsToolStripMenuItem.BackColor = colorDialog1.Color;
                themesToolStripMenuItem.BackColor = colorDialog1.Color;
                fontToolStripMenuItem1.BackColor = colorDialog1.Color;
                toolStripSeparator1.BackColor = colorDialog1.Color;
                toolStripSeparator2.BackColor = colorDialog1.Color;
            }
        }
        private void OnMenustripColor2(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.ShowHelp = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
            }

            private void OnThemeFont (object sender, EventArgs e)
        {
            fontDialog2.ShowColor = true;
            fontDialog2.MaxSize = Convert.ToInt32(fileToolStripMenuItem.Font.Size);
            fontDialog2.MinSize = fontDialog2.MaxSize;
            fontDialog2.Font = menuStrip1.Font;
            fontDialog2.Color = menuStrip1.ForeColor;

            if (fontDialog2.ShowDialog() != DialogResult.Cancel)
            {
                menuStrip1.Font = fontDialog2.Font;
                menuStrip1.ForeColor = fontDialog2.Color;
                newToolStripMenuItem.Font = fontDialog2.Font;
                newToolStripMenuItem.ForeColor = fontDialog2.Color;
                openToolStripMenuItem.Font = fontDialog2.Font;
                openToolStripMenuItem.ForeColor = fontDialog2.Color;
                saveToolStripMenuItem.Font = fontDialog2.Font;
                saveToolStripMenuItem.ForeColor = fontDialog2.Color;
                saveAsToolStripMenuItem.Font = fontDialog2.Font;
                saveAsToolStripMenuItem.ForeColor = fontDialog2.Color;
                exitToolStripMenuItem.Font = fontDialog2.Font;
                exitToolStripMenuItem.ForeColor = fontDialog2.Color;
                undoToolStripMenuItem.Font = fontDialog2.Font;
                undoToolStripMenuItem.ForeColor = fontDialog2.Color;
                redoToolStripMenuItem.Font = fontDialog2.Font;
                redoToolStripMenuItem.ForeColor = fontDialog2.Color;
                fontToolStripMenuItem.Font = fontDialog2.Font;
                fontToolStripMenuItem.ForeColor = fontDialog2.Color;
                colorsToolStripMenuItem.Font = fontDialog2.Font;
                colorsToolStripMenuItem.ForeColor = fontDialog2.Color;
                themesToolStripMenuItem.Font = fontDialog2.Font;
                themesToolStripMenuItem.ForeColor = fontDialog2.Color;
                fontToolStripMenuItem1.Font = fontDialog2.Font;
                fontToolStripMenuItem1.ForeColor = fontDialog2.Color;
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBoxBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }
    }
}