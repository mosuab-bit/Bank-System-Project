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
    public partial class UCPersonCardWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }
        public UCPersonCardWithFilter()
        {
            InitializeComponent();
        }
        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;
            }
        }

        public int PersonID
        {
            get { return ucPersonInfo1.PersonID; }
        }

        public clsPerson PersonSelctedInfo
        {
            get { return ucPersonInfo1.PersonSelectedInfo; }
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            AddUpdatePerson addUpdatePerson = new AddUpdatePerson();
            addUpdatePerson.DataBack += DataEventBack;
            addUpdatePerson.ShowDialog();
        }

        private void DataEventBack(object sender,int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ucPersonInfo1.LoadData(PersonID);
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
            get { return _FilterEnabled; }
        }
        private void _FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ucPersonInfo1.LoadData(int.Parse(txtFilterValue.Text));

                    break;

                case "National No.":
                    ucPersonInfo1.LoadData(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(ucPersonInfo1.PersonID);
        }

        public void LoadPersonInfo(int PersonID)
        {

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            _FindNow();

        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void UCPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtFilterValue, "This field is required!");
            //}
            //else
            //{
            //    //e.Cancel = false;
            //    errorProvider1.SetError(txtFilterValue, null);
            //}
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _FindNow();
        }
    }
}
