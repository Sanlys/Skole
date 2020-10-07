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
            if(savedPath == string.Empty)
            {
                OnSaveAs(sender, e);
            } else
            {
                OnSave(sender, e);
            }

            System.Windows.Forms.Application.Exit();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
