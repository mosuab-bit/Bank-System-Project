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
    public partial class ChangePincode : Form
    {
        private int _ClientID = -1;
        private clsClients _Client;
        public ChangePincode(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current Pincode cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            if (_Client.PinCode != txtCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current Pincode is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void ChangePincode_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _Client=clsClients.FindClientByID(_ClientID);
            if (_Client == null)
            {
                MessageBox.Show("Could not Find Client with id = " + _ClientID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;

            }
            ucClientInfo1.LoadDataClient(_ClientID);
        }

        private void txtNewPincode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPincode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPincode, "Current New Pincode cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPincode, null);
            }
        }

        private void txtConfirmPincode_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPincode.Text.Trim() != txtNewPincode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPincode, "Confirm Pincode doesn't match New Pincode ");
                return;
            } 
            else
            {
                errorProvider1.SetError(txtNewPincode, null);
            }
        }
        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPincode.Text = "";
            txtConfirmPincode.Text = "";
            txtCurrentPassword.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                 "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Client.PinCode = txtNewPincode.Text.Trim();
            if(_Client.Save())
            {
                MessageBox.Show("Pincode Changed Successfully.",
                                          "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Error Occured, Pincode did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
