using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Finder
{
    class Dentist
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string LicenseCountryName { get; set; }
        public int LicenseNumber { get; set; }
        public int YearsInPractice { get; set; }
        public bool Gender { get; set; }
        public List<Education> EducationList;
        public List<Address> AddresseList;
        
        

        public Dentist()
        {
            EducationList = new List<Education>();
            AddresseList = new List<Address>();
        }
    }
}
