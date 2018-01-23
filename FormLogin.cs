using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxAuthenticationManager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        
        private void buttonLoginButton_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "AsadHashmi" && textBoxPassword.Text == "@s@d&*^MobilityDub@i")
            {
                FormMain FM = new FormMain();
                this.Hide();
                FM.ShowDialog();
                
                this.Show();
                textBoxUserName.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                textBoxUserName.Text = "";
                textBoxPassword.Text = "";
                MessageBox.Show("Error 401.");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

       

    }
}
