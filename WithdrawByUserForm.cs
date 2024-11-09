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
    public partial class WithdrawByUserForm : Form
    {
        private int _ClientID = -1;
        private clsClients _Client;

        public WithdrawByUserForm()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            txtDAccNum.Focus();
            txtDAccNum.Clear();
            txtWithdrawAmount.Clear();
            lblDBalance.Text = "[???]";
            lblDClientID.Text = "[???]";
            lblDFName.Text = "[???]";
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtDAccNum.Text.Trim()=="")
            {
                _ResetDefaultValues();
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Client = clsClients.FindClientByAccNum(txtDAccNum.Text.Trim());
            if (_Client == null)
            {
                _ResetDefaultValues();
                MessageBox.Show("There is no Client With this Account Number " + txtDAccNum.Text,
                   "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblDClientID.Text = _Client.ClientID.ToString();
            lblDFName.Text = _Client.PersonInfo.FullName;
            lblDBalance.Text = _Client.Balance.ToString();
        }

        private void txtDAccNum_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtDAccNum.Text.Trim()))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtDAccNum, "Must Fill This Field");
            //    return;
            //}
            //else
            //{
            //    errorProvider1.SetError(txtDAccNum, null);
            //}
        }

        private void txtWithdrawAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show("Are You Sure You Want To Execute This Operation ?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if(_Client.Balance>=Convert.ToInt32(txtWithdrawAmount.Text))
                {
                    _Client.Balance -= Convert.ToInt32(txtWithdrawAmount.Text);
                    if (_Client.Save())
                    {
                        MessageBox.Show("Operation Done Successfully");
                        lblDBalance.Text = _Client.Balance.ToString();
                        txtWithdrawAmount.Text = "";
                        txtWithdrawAmount.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed , Please Try Again",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtWithdrawAmount.Text = "";
                        txtWithdrawAmount.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Amount Bigger Than Balance",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWithdrawAmount.Text = "";
                    txtWithdrawAmount.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDAccNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
        }
    }
}
