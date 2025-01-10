using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLearning
{
    public partial class Form1 : Form
    {

        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void butCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (butCheckBox.Checked) {
                pass.Visible = false;
                butSignUp.Visible = false;  
                flag = true;
            }
            else
            {
                pass.Visible = true;    
                butSignUp.Visible = true;
                flag = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
