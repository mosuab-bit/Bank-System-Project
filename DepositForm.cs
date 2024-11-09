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
    public partial class DepositForm : Form
    {
        
        public DepositForm()
        {
            InitializeComponent();
            
        }

        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDepositAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepositAmount.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDepositAmount, "Must Fill This Field");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDepositAmount, null);
            }
        }

        private void btnExecute_Click_1(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are You Sure You Want To Execute This Operation ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsGlobalClient.CurrentClient.Balance += Convert.ToDecimal(txtDepositAmount.Text);
                if (clsGlobalClient.CurrentClient.Save())
                {
                    MessageBox.Show("Operation Done Successfully , Your Balance = "+clsGlobalClient.CurrentClient.Balance.ToString());
                    txtDepositAmount.Text = "";
                    txtDepositAmount.Focus();
                }
                else
                {
                    MessageBox.Show("Error Happened Try Again");
                    txtDepositAmount.Text = "";
                    txtDepositAmount.Focus();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDepositAmount.Clear();
            txtDepositAmount.Focus();
        }
    }
}
