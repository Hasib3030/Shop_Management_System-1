using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUN.Text=="Nazib"&& txtPass.Text=="123")
            {
                lblerroruser.Visible = false;
                
                MessageBox.Show("Logged in", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblerroruser.Visible = true;
                
            }
        }
    }
}
