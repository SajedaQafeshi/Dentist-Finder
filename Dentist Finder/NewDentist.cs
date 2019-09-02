using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Finder
{
    public partial class NewDentist : Form
    {
        List<Education> educations;
        List<Address> addresses;
        List<Specialty> specialties;
        
        public NewDentist()
        {
            InitializeComponent();
            educations = new List<Education>();
            addresses = new List<Address>();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckIsSpecialist.Checked == true)
            {
                speciality.Visible = true;
                specialties = new List<Specialty>();
            }
            else
            {
                speciality.Visible = false;
                specialties = null;
            }
        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (txtDegree.Text == "" && txtMajor.Text == "" &&
                txtSchool.Text == "" && txtYear.Text == "")
                MessageBox.Show("-_-");
            else
            {
                educations.Add(new Education()
                {
                    Degree = txtDegree.Text,
                    Major = txtMajor.Text,
                    School = txtSchool.Text,
                    Year = Int32.Parse(txtYear.Text)
                });
                MessageBox.Show("Done ^_^ ");
                txtDegree.Text = "";
                txtMajor.Text = "";
                txtSchool.Text = "";
                txtYear.Text = "";
            }
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            if (txtCountry.Text == "" && txtCity.Text == "" &&
                txtState.Text == "" && txtPosalCode.Text =="" &&
                txtStreet.Text =="")
                MessageBox.Show("-_-");
            else
            {
                addresses.Add(new Address()
                {
                    Country = txtCountry.Text,
                    City =txtCity.Text,
                    State=txtState.Text,
                    Street =txtStreet.Text,
                    PostalCode=Int32.Parse(txtPosalCode.Text)
                });
                MessageBox.Show("Done ^_^ ");

                txtCountry.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                txtPosalCode.Text = "";
                txtStreet.Text = "";
            }
        }

        private void btnAddSpecialty_Click(object sender, EventArgs e)
        {
            if(CheckIsSpecialist.Checked == true)
            {
                if (txtAreaOfSpecialization.Text == "" && txtStartYear.Text == "")
                    MessageBox.Show("-_-");
                else
                {
                    specialties.Add(new Specialty()
                    {
                        AreaOfSpecialization = txtAreaOfSpecialization.Text,
                        StartYear = Int32.Parse(txtStartYear.Text)
                    });
                    MessageBox.Show("Done ^_^ ");
                    txtAreaOfSpecialization.Text = "";
                    txtStartYear.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDentist_Click(object sender, EventArgs e)
        {
            

            if(txtfirstName.Text == ""&& txtlastName.Text == ""&& txtwebsite.Text == ""&&
                 txtphone.Text == ""&& txtlicenseCountry.Text == "" && txtlicenseNumber.Text==""&&
                 txtYearInPractice.Text =="")
            {
                MessageBox.Show("-_-");

            }
            else
            {
                string FirstName = txtfirstName.Text;
                string LastName = txtlastName.Text;
                string Website = txtwebsite.Text;
                string Phone = txtphone.Text;
                string Email = txtemail.Text;
                string LicenseCountryName = txtlicenseCountry.Text;
                int LicenseNumber = Int32.Parse(txtlicenseNumber.Text);
                int YearsInPractice = Int32.Parse(txtYearInPractice.Text);
                bool Gender = false;
                if (Femal.Checked == true)
                    Gender = true;
                else
                    Gender = false;
                if(CheckIsSpecialist.Checked == true)
                {
                    ConcreteSpecialtyDentistBuilder SpecialtyDentist = new ConcreteSpecialtyDentistBuilder();
                    SpecialtyDentist.dentist.FirstName = FirstName;
                    SpecialtyDentist.dentist.LastName = LastName;
                    SpecialtyDentist.dentist.Website = Website;
                    SpecialtyDentist.dentist.Phone = Phone;
                    SpecialtyDentist.dentist.Email = Email;
                    SpecialtyDentist.dentist.LicenseCountryName = LicenseCountryName;
                    SpecialtyDentist.dentist.LicenseNumber = LicenseNumber;
                    SpecialtyDentist.dentist.YearsInPractice = YearsInPractice;
                    SpecialtyDentist.dentist.Gender = Gender;


                    SpecialtyDentist.EducationListBuilder(educations);
                    SpecialtyDentist.AddresseListBuilder(addresses);
                    SpecialtyDentist.SpecialtieListBuilder(specialties);

                    MessageBox.Show("Done");
                }
                else
                {
                    ConcreteDentistBuilder concreteDentist = new ConcreteDentistBuilder();
                    concreteDentist.dentist.FirstName = FirstName;
                    concreteDentist.dentist.LastName = LastName;
                    concreteDentist.dentist.Website = Website;
                    concreteDentist.dentist.Phone = Phone;
                    concreteDentist.dentist.Email = Email;
                    concreteDentist.dentist.LicenseCountryName = LicenseCountryName;
                    concreteDentist.dentist.LicenseNumber = LicenseNumber;
                    concreteDentist.dentist.YearsInPractice = YearsInPractice;
                    concreteDentist.dentist.Gender = Gender;

                    concreteDentist.EducationListBuilder(educations);
                    concreteDentist.AddresseListBuilder(addresses);
                    
                    MessageBox.Show("Done");

                }
            }
         }
    }
}
