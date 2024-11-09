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
    public partial class ClientForm : Form
    {
        
        public ClientForm()
        {
            InitializeComponent();
            
        }

        private void withdrawToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WithdrawScreen withdrawScreen = new WithdrawScreen();
            withdrawScreen.ShowDialog();
        }

        private void depositToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.ShowDialog();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.ShowDialog();
        }

        private void changePinCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePincode changePincode = new ChangePincode(clsGlobalClient.CurrentClient.ClientID);
            changePincode.ShowDialog();
        }
    }
}
