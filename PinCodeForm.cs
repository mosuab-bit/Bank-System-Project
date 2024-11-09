using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project_C_
{
    public partial class PinCodeForm : Form
    {
        public PinCodeForm()
        {
            InitializeComponent();
        }

        private void btnExecute_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are You Sure You Want To Change PINCODE ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                clsGlobalClient.CurrentClient.PinCode = txtNewPinCode.Text;
                
                    if (clsGlobalClient.CurrentClient.Save())
                    {
                        MessageBox.Show("PINCODE Updated Successfuly");
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed Try Again");

                    }
                

            }
        }

        private void txtCurrentPincode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCurrentPincode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPincode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPincode, "Pincode cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPincode, null);
            };

            if (clsGlobalClient.CurrentClient.PinCode != txtCurrentPincode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPincode, "Current Pincode is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPincode, null);
            };
        }

        private void txtNewPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPinCode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPinCode, "Pincode cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPinCode, null);
            }
        }

        private void txtConfirmPincode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPincode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPincode, "Pincode cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPincode, null);
            }

            if(txtNewPinCode.Text.Trim()!=txtConfirmPincode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPincode, "Pincode is not match new Password");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPincode, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
