using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorGUI
{
    public partial class Main : Form
    {
        int i = 1;
        Form1[] formarray = new Form1[10];
        public Main()
        {
            InitializeComponent();
            formarray[0] = new Form1();
            formarray[0].MdiParent = this;
            formarray[0].Show();
            
        }
        private void closeAllWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.MdiParent = this;
            x.Show();


            /*formarray[i] = new Form1();
            formarray[i].MdiParent = this;
            formarray[i].Show();
            i++;*/
        }
    }
}
