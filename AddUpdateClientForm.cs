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
    public partial class AddUpdateClientForm : Form
    {
        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        private int _ClientID = -1;
        private clsClients _Client;

        public AddUpdateClientForm(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
            _Mode = enMode.Update;
        }

        public AddUpdateClientForm()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Client";
                this.Text = lblTitle.Text;
                btnSave.Enabled = false;
                tbClientInfo.Enabled = false;
                _Client = new clsClients();
            }
            else
            {
                lblTitle.Text = "Update Client Info";
                this.Text = lblTitle.Text;
                btnSave.Enabled = true;
                tbClientInfo.Enabled = true;
            }

            txtAccountNumber.Text = "";
            txtBalance.Text = "";
            txtPincode.Text = "";
            txtConfirmPincode.Text = "";
        }

        private void _LoadClientData()
        {
            _Client = clsClients.FindClientByID(_ClientID);
            if (_Client == null)
            {
                MessageBox.Show("There is no Client with this Client ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _ClientID = _Client.ClientID;
            ucPersonCardWithFilter1.LoadPersonInfo(_Client.PersonID);
            ucPersonCardWithFilter1.FilterEnabled = false;
            lblClientID.Text = _Client.ClientID.ToString();
            txtAccountNumber.Text = _Client.AccountNumber;
            txtBalance.Text = _Client.Balance.ToString();
            txtPincode.Text = _Client.PinCode;
            txtConfirmPincode.Text = _Client.PinCode;
        }
        private void AddUpdateClientForm_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
            {
                _LoadClientData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ucPersonCardWithFilter1.PersonID != -1)
            {
                if (clsClients.IsClientExistForPersonID(ucPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a Client, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ucPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tbClientInfo.Enabled = true;
                    //tabControl1.SelectedTab = tabControl1.TabPages["tpLoginInfo"];
                    tabControl1.SelectedIndex = 1;
                }
            }
            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonCardWithFilter1.FilterFocus();

            }
        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtAccountNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAccountNumber, "Account Number cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAccountNumber, null);
            }

            if (_Mode == enMode.AddNew)
            {
                if (clsUsers.IsUserExist(txtAccountNumber.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtAccountNumber, "Account Number is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtAccountNumber, null);
                }

            }
            else
            {
                if (_Client.AccountNumber != txtAccountNumber.Text.Trim())
                {
                    if (clsUsers.IsUserExist(txtAccountNumber.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtAccountNumber, "Account Number is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtAccountNumber, null);
                    }
                }
            }
        }

        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAccountNumber, "Balance cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAccountNumber, null);
            }
        }

        private void txtPincode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPincode.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPincode, "Pincode cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPincode, null);
            }
        }

        private void txtConfirmPincode_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPincode.Text.Trim() != txtPincode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPincode, "Pincode Confirmation does not match Pincode!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPincode, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Client.AccountNumber = txtAccountNumber.Text;
            _Client.Balance = Convert.ToDecimal(txtBalance.Text);
            _Client.PinCode = txtPincode.Text;
            _Client.PersonID = ucPersonCardWithFilter1.PersonID;

            if (_Client.Save())
            {
                lblClientID.Text = _Client.ClientID.ToString();

                _Mode = enMode.Update;
                lblTitle.Text = "Update Client Info";
                this.Text = lblTitle.Text;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

