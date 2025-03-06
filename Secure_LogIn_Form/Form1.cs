using Microsoft.VisualBasic.Logging;

namespace Secure_LogIn_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogIn.Enabled = false;
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordtxt.Text))
            {
                LogIn.Enabled = false;
            }
            else
            {

                LogIn.Enabled = false;
                if (string.IsNullOrWhiteSpace(passwordtxt.Text))
                {
                    LogIn.Enabled = false;
                }
                else if (!string.IsNullOrWhiteSpace(usernametxt.Text) && !string.IsNullOrWhiteSpace(passwordtxt.Text))
                {
                    LogIn.Enabled = true;
                }
                else if (string.IsNullOrWhiteSpace(usernametxt.Text) && !string.IsNullOrWhiteSpace(passwordtxt.Text))
                {
                    LogIn.Enabled = false;
                }
                else if (!string.IsNullOrWhiteSpace(usernametxt.Text) && string.IsNullOrWhiteSpace(passwordtxt.Text))
                {
                    LogIn.Enabled = false;
                }
            }
        }


        private void usernametxt_MouseClick(object sender, MouseEventArgs e)
        {
            usernametxt.Clear();
        }

        private void passwordtxt_MouseClick(object sender, MouseEventArgs e)
        {
            passwordtxt.Clear();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            
        }

        private void passwordtxt_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametxt.Text))
            {
                LogIn.Enabled = false;                

            }
            else
            {

                LogIn.Enabled = false;
                if (string.IsNullOrWhiteSpace(usernametxt.Text))
                {
                    LogIn.Enabled = false;
                }
                else if (!string.IsNullOrWhiteSpace(usernametxt.Text) && !string.IsNullOrWhiteSpace(passwordtxt.Text))
                {
                    LogIn.Enabled = true;
                }
                else if (string.IsNullOrWhiteSpace(usernametxt.Text) && !string.IsNullOrWhiteSpace(passwordtxt.Text))
                {
                    LogIn.Enabled = false;
                }
                else if (!string.IsNullOrWhiteSpace(usernametxt.Text) && string.IsNullOrWhiteSpace(passwordtxt.Text))
                {
                    LogIn.Enabled = false;
                }
            }
        }

      
        
    }
}
