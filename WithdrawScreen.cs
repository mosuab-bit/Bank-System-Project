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
    public partial class WithdrawScreen : Form
    {
        
      
        public WithdrawScreen()
        {
            InitializeComponent();
           
        }

        private void DetermineWithdraw(Button btn)
        {
            if (MessageBox.Show("Are You Sure You Want To Execute This Operation ?","Questin",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                
                if (btn.Tag.ToString() == "20")
                {
                    

                    if (clsGlobalClient.CurrentClient.Balance>20&& clsGlobalClient.CurrentClient.Withdraw(20))

                        MessageBox.Show("Operation Done Successfully");
                    else
                        MessageBox.Show("Something Wrong Try Again");
                }
                else if(btn.Tag.ToString() =="50")
                {
                    if (clsGlobalClient.CurrentClient.Balance > 50 && clsGlobalClient.CurrentClient.Withdraw(50))

                        MessageBox.Show("Operation Done Successfully");
                    else
                        MessageBox.Show("Something Wrong Try Again");
                }
                else if(btn.Tag.ToString() =="100")
                {
                    if (clsGlobalClient.CurrentClient.Balance > 100 && clsGlobalClient.CurrentClient.Withdraw(100))

                        MessageBox.Show("Operation Done Successfully");
                    else
                        MessageBox.Show("Something Wrong Try Again");
                }
                else if(btn.Tag.ToString() =="200")
                {
                    if (clsGlobalClient.CurrentClient.Balance > 200 && clsGlobalClient.CurrentClient.Withdraw(200))

                        MessageBox.Show("Operation Done Successfully");
                    else
                        MessageBox.Show("Something Wrong Try Again");
                }
                else if (btn.Tag.ToString() =="400")
                {
                    if (clsGlobalClient.CurrentClient.Balance > 400 && clsGlobalClient.CurrentClient.Withdraw(400))

                        MessageBox.Show("Operation Done Successfully");
                    else
                        MessageBox.Show("Something Wrong Try Again");
                }
                else
                {
                    if (clsGlobalClient.CurrentClient.Balance > 600 && clsGlobalClient.CurrentClient.Withdraw(600))

                        MessageBox.Show("Operation Done Successfully");
                    else
                        MessageBox.Show("Something Wrong Try Again");
                }
            }
          
        }
        private void button_Click(object sender, EventArgs e)
        {
            DetermineWithdraw((Button)sender);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            CustomForm frm = new CustomForm();
            frm.ShowDialog();
        }
    }
}
