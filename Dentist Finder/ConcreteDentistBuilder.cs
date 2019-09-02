using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Finder
{
    class ConcreteDentistBuilder : DentistBuilder
    {
        public Dentist dentist;

        public ConcreteDentistBuilder()
        {
            dentist = new Dentist();
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

       
    }
}
