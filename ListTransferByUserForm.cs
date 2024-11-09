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
    public partial class ListTransferByUserForm : Form
    {
        public ListTransferByUserForm()
        {
            InitializeComponent();
        }

        private void ListTransferByUserForm_Load(object sender, EventArgs e)
        {
            DataTable dt = clsTransfer.GetAllDataTransfer();
            dataGridView1.DataSource = dt;
        }
    }
}
