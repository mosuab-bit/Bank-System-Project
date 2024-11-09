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
    public partial class UCUserInfo : UserControl
    {
        private int _UserID = -1;
        private clsUsers _User;
        public UCUserInfo()
        {
            InitializeComponent();
        }

        public int UserID
        {
            get { return _UserID; }
        }

        public clsUsers UserInfo
            { get { return _User; } }

        public void LoadDataUser(int UserID)
        {
            _User = clsUsers.Find(UserID);
            if(_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person For This ID");
                return;
            }

            _FillUserInfo();

        }
        private void _ResetPersonInfo()
        {

            ucPersonInfo1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
        }
        private void _FillUserInfo()
        {
            _UserID = _User.UserId;
            ucPersonInfo1.LoadData(_User.PersonID);
            lblUserID.Text = _UserID.ToString();
            lblUserName.Text = _User.UserName;
        }
        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
