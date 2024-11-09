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
    public partial class MainSignScreen : Form
    {
        
        public MainSignScreen() => InitializeComponent();

        

        
        private void btnClient_Click(object sender, EventArgs e)
        {
            LoginClientForm loginForm = new LoginClientForm();
            loginForm.ShowDialog();
        }

        

        private void btnUser_Click(object sender, EventArgs e)
        {
            LoginUserForm loginForm = new LoginUserForm();
            loginForm.ShowDialog();
        }

        
    }
}
