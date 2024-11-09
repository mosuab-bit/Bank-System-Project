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
    public partial class TransferByUserForm : Form
    {
        public TransferByUserForm()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                                 "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSenderAccNum.Text.ToString() != txtRecieveAccNum.Text.ToString())
            {
                clsClients _ClientFrom = clsClients.FindClientByAccNum(txtSenderAccNum.Text.ToString());
                clsClients _ClientTo = clsClients.FindClientByAccNum(txtRecieveAccNum.Text.ToString());
                if (_ClientFrom != null && _ClientTo != null)
                {
                    if (_ClientFrom.Balance > Convert.ToDecimal(txtTransferAmount.Text))
                    {
                        _ClientFrom.Balance = _ClientFrom.Balance - Convert.ToDecimal(txtTransferAmount.Text);
                        _ClientTo.Balance = _ClientTo.Balance + Convert.ToDecimal(txtTransferAmount.Text);

                        if (MessageBox.Show("Are You Sure To Execute This Operation ?", "Question", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if (_ClientFrom.Save() && _ClientTo.Save())
                            {
                                MessageBox.Show("Operation Done Successfully", "", MessageBoxButtons.OK);
                                clsTransfer.InsertTransferData(DateTime.Now, _ClientFrom.ClientID,
                                    _ClientTo.ClientID, Convert.ToDecimal(txtTransferAmount.Text.Trim()),
                                    _ClientFrom.Balance, _ClientTo.Balance, clsGlobalUser.CurrentUser.UserId);
                            }
                            else
                            {
                                MessageBox.Show("Something Wrong Try Again", "", MessageBoxButtons.OK);
                            }

                        }


                    }
                    else
                    {
                        MessageBox.Show("Ammount You Want To Transfer Bigger Than Balance For This Account", "Warnning", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Something Wrong Try Again", "", MessageBoxButtons.OK);

                }


            }
            else
            {
                MessageBox.Show("Can not Transfer From The Same Account", "", MessageBoxButtons.OK);
                txtSenderAccNum.Text = "";
                txtRecieveAccNum.Text = "";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSenderAccNum.Clear();
            txtRecieveAccNum.Clear();
            txtTransferAmount.Clear();
            txtSenderAccNum.Focus();
        }

        private void txtValidating_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "Must Fill This Field");
                return;
            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void txtTransferAmount_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
