using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Finder
{
    class ConcreteSpecialtyDentistBuilder : DentistBuilder
    {
        public Dentist dentist;
        public List<Specialty> SpecialtieList;

        public ConcreteSpecialtyDentistBuilder()
        {
            dentist = new Dentist();
            SpecialtieList = new List<Specialty>();

        }

        public Dentist GetDentist()
        {
            return dentist;
        }

        public void AddresseListBuilder(List<Address> addresses)
        {
            dentist.AddresseList = addresses;
        }

        public void EducationListBuilder(List<Education> educations)
        {
            dentist.EducationList = educations;
        }

        
        public void SpecialtieListBuilder(List<Specialty> specialties)
        {
            SpecialtieList = specialties;
        }

    }
}
