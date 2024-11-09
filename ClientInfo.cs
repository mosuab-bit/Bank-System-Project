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
    public partial class ClientInfo : Form
    {
        private int _ClientID = -1;
        public ClientInfo(int clientID)
        {
            InitializeComponent();
            _ClientID = clientID;
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            ucClientInfo1.LoadDataClient(_ClientID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
