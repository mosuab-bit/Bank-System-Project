using Bank_Project_C_.Properties;
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
    public partial class UCPersonInfo : UserControl
    {
        private int _PersonID;
        clsPerson _Person;
        public UCPersonInfo()
        {
            InitializeComponent();
        }

        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson PersonSelectedInfo
        {
            get { return _Person; }
        }
        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGendor.Image = Resources.Male;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Male;

        }
        public void LoadData(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if(_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person For This ID");
                return;
            }

            _FillPersonInfo();
         
        }

        public void LoadData(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person For This ID");
                return;
            }

            _FillPersonInfo();

        }
        private void _FillPersonInfo()
        {

            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonId;
            lblPersonID.Text = _PersonID.ToString();
            lblFullName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblEmail.Text = _Person.Email;
            if (_Person.Gender == 0)
            {
                pbGendor.Image = Resources.user_32_2;
                lblGendor.Text = "Male";
            }
            else
            {
                pbGendor.Image = Resources.user_female;
                lblGendor.Text = "Female";
            }
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblPhone.Text = _Person.Phone;
            lblAddress.Text = _Person.Address;
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }
            else
            {
                if (_Person.Gender == 0)
                    pbPersonImage.Image = Resources.Male;
                else
                    pbPersonImage.Image = Resources.Female;
            }
        }
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdatePerson addUpdatePerson = new AddUpdatePerson(_PersonID);
            addUpdatePerson.ShowDialog();
            LoadData(_PersonID);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
