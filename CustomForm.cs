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
    public partial class CustomForm : Form
    {
        
        public CustomForm()
        {
            InitializeComponent();
            
        }
 

        private void btnCustom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(clsGlobalClient.CurrentClient.Balance>Convert.ToDecimal(txtWithdrawAmount.Text))
            {
                if(MessageBox.Show("Are You Sure To Execute This Operation ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(clsGlobalClient.CurrentClient.Withdraw(Convert.ToDecimal(txtWithdrawAmount.Text)))
                    {
                        MessageBox.Show("Operation Done Successfully, Your Balance = " + clsGlobalClient.CurrentClient.Balance.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error Happened Try Again");

                    }
                }
            }
            else
            {
                MessageBox.Show("Amount Bigger Than Your Balance","Warnning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtWithdrawAmount.Text = "";
                txtWithdrawAmount.Focus();

            }
        }

        private void txtWithdrawAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtWithdrawAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtWithdrawAmount.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtWithdrawAmount, "Must Fill This Field");
                return;
            }
            else
            {
                errorProvider1.SetError(txtWithdrawAmount, null);
            }
        }
    }
}
