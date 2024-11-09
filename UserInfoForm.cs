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
    public partial class UserInfoForm : Form
    {
        private int _UserID = -1;
        public UserInfoForm(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            ucUserInfo1.LoadDataUser(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
