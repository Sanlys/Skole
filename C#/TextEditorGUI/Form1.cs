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

            richTextBox1.Text = "abcdefg";
            richTextBox1.Font = new Font("Consolas", 12, FontStyle.Regular);

            button1.Click += (sender, EventArgs) => { OnClick(sender, EventArgs); };
            button2.Click += (sender, EventArgs) => { OnClick2(sender, EventArgs); };

           

        }

        private void OnClick(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
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
        private void OnClick2(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog1.FileName;
                    richTextBox1.Text = (File.ReadAllText(filePath));

                }
            }
        }
        


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
