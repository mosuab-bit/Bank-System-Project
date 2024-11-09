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
    public partial class DepositeByUserForm : Form
    {
        private int ClientID = -1;
        private clsClients _Client;
        public DepositeByUserForm()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            txtDAccNum.Clear();
            txtDDepositAmount.Clear();
            lblDBalance.Text = "[???]";
            lblDClientID.Text = "[???]";
            lblDFName.Text = "[???]";
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtDAccNum.Text.Trim()=="")
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Client = clsClients.FindClientByAccNum(txtDAccNum.Text.Trim());
            if(_Client==null)
            {
                _ResetDefaultValues();
                MessageBox.Show("There is no Client With this Account Number "+txtDAccNum.Text,
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

        private void txtDDepositAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDDepositAmount.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDDepositAmount, "Must Fill This Field");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDDepositAmount, null);
            }
        }

        private void txtDDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
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
            if (MessageBox.Show("Are You Sure You Want To Execute This Operation","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                _Client.Balance += Convert.ToDecimal(txtDDepositAmount.Text);
                if(_Client.Save())
                {
                    MessageBox.Show("Operation Done Successfully");
                    lblDBalance.Text = _Client.Balance.ToString();
                    txtDDepositAmount.Text = "";
                    txtDDepositAmount.Focus();
                }
                else
                {
                    MessageBox.Show("Operation Failed, Try Again");
                    txtDDepositAmount.Text = "";
                    txtDDepositAmount.Focus();
                }
            }
            else
            {
                txtDDepositAmount.Text = "";
                txtDDepositAmount.Focus();
            }
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
