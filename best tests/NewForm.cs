using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace best_tests
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
               
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

                checkBox1.Checked = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                label3.Text = "it is wrong";
            }
            else
            {
                label3.Text = "it is right";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {

                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {

                checkBox3.Checked = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                label5.Text = "it is right";
            }
            else
            {
                label5.Text = "it is wrong";
            }
        }
    }
}
