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
    public partial class ListClientForm : Form
    {
        private DataTable _dtAllClients;
        public ListClientForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListClientForm_Load(object sender, EventArgs e)
        {
            _dtAllClients = clsClients.GetAllClients();
            cbFilterBy.SelectedIndex = 0;
            dgvClients.DataSource = _dtAllClients;
            lblRecordsCount.Text = dgvClients.Rows.Count.ToString();
            if(dgvClients.Rows.Count > 0 )
            {
                dgvClients.Columns[0].HeaderText = "Client ID";
                dgvClients.Columns[0].Width = 110;

                dgvClients.Columns[1].HeaderText = "Account Number";
                dgvClients.Columns[1].Width = 120;

                dgvClients.Columns[2].HeaderText = "Full Name";
                dgvClients.Columns[2].Width = 350;

                dgvClients.Columns[3].HeaderText = "Balance";
                dgvClients.Columns[3].Width = 120;

                dgvClients.Columns[4].HeaderText = "Person ID";
                dgvClients.Columns[4].Width = 120;
 
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUpdateClientForm addUpdateClientForm = new AddUpdateClientForm();
            addUpdateClientForm.ShowDialog();
            ListClientForm_Load(null, null);
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateClientForm addUpdateClientForm = new AddUpdateClientForm();
            addUpdateClientForm.ShowDialog();
            ListClientForm_Load(null, null);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateClientForm addUpdateClientForm = new AddUpdateClientForm((int)dgvClients.CurrentRow.Cells[0].Value);
            addUpdateClientForm.ShowDialog();
            ListClientForm_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To Delete This Client ?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if (clsClients.DeleteClient((int)dgvClients.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Data Deleted Successfully");
                    ListClientForm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Client is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientInfo clientInfo = new ClientInfo((int)dgvClients.CurrentRow.Cells[0].Value);
            clientInfo.ShowDialog();
        }

        private void changePincodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePincode changePincode = new ChangePincode((int)dgvClients.CurrentRow.Cells[0].Value);
            changePincode.ShowDialog();
        }

        private void dgvClients_DoubleClick(object sender, EventArgs e)
        {
            ClientInfo clientInfo = new ClientInfo((int)dgvClients.CurrentRow.Cells[0].Value);
            clientInfo.ShowDialog();
        }

        private void txtFilterValue_Validated(object sender, EventArgs e)
        {

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID"||cbFilterBy.Text=="Client ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.SelectedIndex != 0);
            if(txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch(cbFilterBy.Text)
            {
                case "Client ID":
                    FilterColumn = "ClientID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Account Number":
                    FilterColumn = "AccountNumber";
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
                _dtAllClients.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvClients.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID" || FilterColumn == "ClientID")

                _dtAllClients.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllClients.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvClients.Rows.Count.ToString();
        }
    }
}
