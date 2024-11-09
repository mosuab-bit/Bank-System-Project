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
    public partial class MainMenueForm : Form
    {
        public MainMenueForm()
        {
            InitializeComponent();
        }
     
        private void logRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginRegistersForm loginRegistersForm = new LoginRegistersForm();
            loginRegistersForm.ShowDialog();
        }

        private void ManagePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListPeopleForm form = new ListPeopleForm();
            form.ShowDialog();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListUserForm form = new ListUserForm();
            form.ShowDialog();
        }

       

        private void manageClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListClientForm form = new ListClientForm();
            form.ShowDialog();
        }

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositeByUserForm depositeByUserForm = new DepositeByUserForm();
            depositeByUserForm.ShowDialog();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawByUserForm withdrawByUserForm = new WithdrawByUserForm();
            withdrawByUserForm.ShowDialog();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           TransferByUserForm transferByUserForm = new TransferByUserForm();
            transferByUserForm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfoForm = new UserInfoForm(clsGlobalUser.CurrentUser.UserId);
            userInfoForm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(clsGlobalUser.CurrentUser.UserId);
            changePasswordForm.ShowDialog();
        }

        private void transactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logRegisterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginRegistersForm loginRegistersForm = new LoginRegistersForm();
            loginRegistersForm.ShowDialog();
        }

        private void listTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListTransferByUserForm list = new ListTransferByUserForm();
            list.ShowDialog();
        }
    }
}
