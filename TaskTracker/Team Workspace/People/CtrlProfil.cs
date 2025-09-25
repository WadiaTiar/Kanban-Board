using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracker.Properties;
using TaskTracker_BusinessLayer;
using System.Xml.Linq;
using System.IO;

namespace TaskTracker.People
{
    public partial class CtrlProfil : UserControl
    {
        public CtrlProfil()
        {
            InitializeComponent();
        }

        /*private clsPeople _Person;

        private int _AccountID = -1;

        public int AccountID
        {
            get { return _AccountID; }
        }

        public clsPeople SelectedPersonInfo
        {
            get { return _Person; }
        }

        public void LoadBasicInfo(int AccountID)
        {
            _Person = clsPeople.Find(AccountID);
            if (_Person == null)
            {
                ResetBasicInfo();
                MessageBox.Show("No Person with AccountID = " + AccountID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillBasicInfo();
        }

        private void _FillBasicInfo()
        {
            lblNational_Num.Text = _Person.National_Num;
            lblFullName.Text = _Person.FullName;
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblBirthDate.Text = _Person.DateOfBirth.ToShortDateString();
            lblAddress.Text = _Person.Address;

            _LoadAccountImage();
        }

        public void ResetBasicInfo()
        {
            lblNational_Num.Text = "[????]";
            lblFullName.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblBirthDate.Text = "[????]";
            lblAddress.Text = "[????]";
            pbAccountImage.Image = imageList1.Images[0];

        }

        private void _LoadAccountImage()
        {
            if (_Person.Gender == 0)
                pbAccountImage.Image = imageList1.Images[0];
            else
                pbAccountImage.Image = imageList1.Images[1];

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbAccountImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ctrlDataProfil_Load(object sender, EventArgs e)
        {

        }*/


    }
}
