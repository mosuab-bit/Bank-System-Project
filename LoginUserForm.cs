using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project_C_
{
    public partial class LoginUserForm : Form
    {
      
        int count, attemp;

        private void _Disable()
        {
            if(attemp==3)
            {
                MessageBox.Show("You Have Reached The Maximum 3 Attemps! \n Please Try Again", "Attemps", MessageBoxButtons.OK);
                attemp = 0;
                count = 25;
                timer1.Enabled = true;
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                btnLogin.Enabled = false;

            }
        }
        public LoginUserForm()
        {
            InitializeComponent();
        }

        private void LoginUserForm_Load(object sender, EventArgs e)
        {
            string Username = "", Password = "";
            if(clsGlobalUser.GetStoredCredential(ref Username,ref Password))
            {
                txtUserName.Text = Username;
                txtPassword.Text = Password;
                chkRemberMe.Checked = true;
            }
            else
            {
                chkRemberMe.Checked = false;
            }
            attemp = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count==0)
            {
                timer1.Enabled = false;
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
                btnLogin.Enabled = true;
                btnLogin.Text = "LOGIN";

            }
            else
            {
                btnLogin.Text = "Log in " + count;
                count = count - 1;
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

            }
        }

        private void LoginUserForm_Activated(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.FindByUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if(User!=null)
            {
                if(chkRemberMe.Checked)
                {
                    clsGlobalUser.RememberUsernameAndPassword(txtUserName.Text.Trim(),txtPassword.Text.Trim());
                }
                else
                {
                    clsGlobalUser.RememberUsernameAndPassword("", "");

                }

                clsGlobalUser.CurrentUser = User;

                clsLogin.AddNewLogin(clsGlobalUser.CurrentUser.UserId, clsGlobalUser.CurrentUser.UserName, DateTime.Now);
                MainMenueForm mainMenueForm = new MainMenueForm();
                mainMenueForm.Show();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                attemp = attemp + 1;
                _Disable();
            }
        }

      
    }
}
