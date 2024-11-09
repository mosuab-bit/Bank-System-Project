﻿using Business_Layer;
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
    public partial class ListUserForm : Form
    {
        private DataTable _dtAllUsers;
        public ListUserForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch(cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "Username";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "UserID" || FilterColumn == "PersonID")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void ListUserForm_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUsers.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();

            if(dgvUsers.Rows.Count>0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "UserName";
                dgvUsers.Columns[1].Width = 120;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 350;

                dgvUsers.Columns[3].HeaderText = "Salary";
                dgvUsers.Columns[3].Width = 120;

                dgvUsers.Columns[4].HeaderText = "Person ID";
                dgvUsers.Columns[4].Width = 120;
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUpdateUser addUpdateUser = new AddUpdateUser();
            addUpdateUser.ShowDialog();
            ListUserForm_Load(null, null);
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateUser addUpdateUser = new AddUpdateUser();
            addUpdateUser.ShowDialog();
            ListUserForm_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateUser addUpdateUser = new AddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            addUpdateUser.ShowDialog();
            ListUserForm_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To Delete This User ? ","Delete User",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (clsUsers.Delete((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Data Deleted Successfully");
                    ListUserForm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm((int)dgvUsers.CurrentRow.Cells[0].Value);
            changePasswordForm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfoForm = new UserInfoForm((int)dgvUsers.CurrentRow.Cells[0].Value);
            userInfoForm.ShowDialog();
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            UserInfoForm userInfoForm = new UserInfoForm((int)dgvUsers.CurrentRow.Cells[0].Value);
            userInfoForm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible=(cbFilterBy.SelectedIndex!=0);
            if(txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
    }
}
