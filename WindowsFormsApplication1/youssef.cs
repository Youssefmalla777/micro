using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class youssef : Form
    {
        public youssef()
        {
            InitializeComponent();
        }

        private void youssef_Load(object sender, EventArgs e)
        {
            
            youssef y = new youssef();
            
            y.MdiParent = this;
            y.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int c=0;c<=100000;c++)
            {
                if(progressBar1 != null)
                {
                    progressBar1.Value = c;
                }
            }
        }
    }
}
