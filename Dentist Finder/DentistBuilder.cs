using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Finder
{
    interface DentistBuilder
    {
        void EducationListBuilder(List<Education> educations);
        void AddresseListBuilder(List<Address> addresses);

        Dentist GetDentist();
    }
}
