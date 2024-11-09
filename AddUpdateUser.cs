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
    public partial class AddUpdateUser : Form
    {
        private enum enMode { AddNew=0,Update=1}
        private enMode _Mode = enMode.AddNew;
        private int _UserID = -1;
        private clsUsers _User;
        
        public AddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }

        public AddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _ResetDefualtValues()
        {
            
            if(_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = lblTitle.Text;
                btnSave.Enabled = false;
                tbLoginInfo.Enabled = false;
                _User = new clsUsers();
            }
            else
            {
                lblTitle.Text = "Update User Info";
                this.Text = lblTitle.Text;
                btnSave.Enabled = true;
                tbLoginInfo.Enabled = true;
            }


            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtSalary.Text = "";

        }
        private void _LoadData()
        {
            _User = clsUsers.Find(_UserID);
            if( _User == null )
            {
                MessageBox.Show("There is no User with this user ID");
                return;
            }

            ucPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            ucPersonCardWithFilter1.FilterEnabled = false;
            lblUserID.Text = _UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtSalary.Text = _User.Salary.ToString();
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            

        }
        private void AddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbLoginInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tpLoginInfo"];
                return;
            }

            if (ucPersonCardWithFilter1.PersonID != -1)
            {
                if (clsUsers.IsUserExistForPersonID(ucPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ucPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tbLoginInfo.Enabled = true;
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

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }

            if(_Mode==enMode.AddNew)
            {
                if(clsUsers.IsUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                }

            }
            else
            {
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUsers.IsUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    }
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text.Trim()!=txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
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

            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.Salary = Convert.ToDecimal(txtSalary.Text);
            _User.PersonID = ucPersonCardWithFilter1.PersonID;
            if(_User.Save())
            {
                lblUserID.Text = _User.UserId.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalary.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSalary, "Salary cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalary, null);
            }
        }

        private void AddUpdateUser_Activated(object sender, EventArgs e)
        {
            ucPersonCardWithFilter1.FilterFocus();
        }
    }
}
