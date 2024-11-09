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
    public partial class LoginRegistersForm : Form
    {
       

        public LoginRegistersForm()
        {
            InitializeComponent();
        }

        private void LoginRegistersForm_Load(object sender, EventArgs e)
        {
            DataTable _dtAllLogin = clsLogin.GetAllLoginRegister();
            dataGridView1.DataSource = _dtAllLogin;

        }
    }
}
