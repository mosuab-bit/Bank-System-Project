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
    public partial class LoginClientForm : Form
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
                txtAccNum.Enabled = false;
                txtPinCode.Enabled = false;
                btnLogin.Enabled = false;
            }
           
        }
        public LoginClientForm()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsClients Client = clsClients.FindClientByAccNumAndClientID(txtPinCode.Text.Trim(), txtAccNum.Text.Trim());
            
            if(Client!=null)
            {
                if(checbRemberMe.Checked)
                {
                    clsGlobalClient.RememberAccountNumberAndPincode(txtAccNum.Text.Trim(), txtPinCode.Text.Trim());
                }
                else
                {
                    clsGlobalClient.RememberAccountNumberAndPincode("", "");
                }

                clsGlobalClient.CurrentClient = Client;
                ClientForm clientForm = new ClientForm();
                clientForm.ShowDialog();
            }
            else
            {
                txtAccNum.Focus();
                MessageBox.Show("Invalid AccountNumber/Pincode.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                attemp = attemp + 1;
                _Disable();
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbShow.Checked==true)
            {
                txtPinCode.UseSystemPasswordChar = false;
            }
            else
            {
                txtPinCode.UseSystemPasswordChar = true;

            }
        }

        private void LoginClientForm_Load(object sender, EventArgs e)
        {
            string AccountNumber = "", Pincode = "";

            if (clsGlobalClient.GetStoredCredential(ref AccountNumber, ref Pincode))
            {
                txtAccNum.Text = AccountNumber;
                txtPinCode.Text = Pincode;
                checbRemberMe.Checked = true;
            }
            else
                checbRemberMe.Checked = false;
        }

        private void LoginClientForm_Activated(object sender, EventArgs e)
        {
            txtAccNum.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count==0)
            {
                timer1.Enabled= false;
                txtAccNum.Enabled = true;
                txtPinCode.Enabled = true;
                btnLogin.Enabled = true;
                btnLogin.Text = "LOGIN";    
            }
            else
            {
                btnLogin.Text = "Log In " + count;
                count = count - 1;
            }
        }

       
    }
}
