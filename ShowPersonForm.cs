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
    public partial class ShowPersonForm : Form
    {
        private int _PersonID = -1;
        public ShowPersonForm(int PersonID)
        {
            InitializeComponent();
            this._PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPersonForm_Load(object sender, EventArgs e)
        {
            ucPersonInfo1.LoadData(_PersonID);
        }
    }
}
