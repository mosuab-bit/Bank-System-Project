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
    public partial class UCClientInfo : UserControl
    {
        private int _ClientID = -1;
        private clsClients _Client;
        public UCClientInfo()
        {
            InitializeComponent();
        }

        public int ClientID
        { get { return _ClientID; } }
        public clsClients Client
            { get { return _Client; } }
        public void LoadDataClient(int ClientID)
        {
             _Client = clsClients.FindClientByID(ClientID);
            if (_Client == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("There is No Client For this ID");
                return;
            }

            _FillClientInfo();
        }
        private void _ResetPersonInfo()
        {

            ucPersonInfo1.ResetPersonInfo();
            lblClientID.Text = "[???]";
            lblBlance.Text = "[???]";
        }
        private void _FillClientInfo()
        {
            _ClientID = _Client.ClientID;
            ucPersonInfo1.LoadData(_Client.PersonID);
            lblClientID.Text = ClientID.ToString();
            lblBlance.Text = Client.Balance.ToString();
        }
    }
}
