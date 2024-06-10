using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databind_ComboBox
{
    public class Citizen
    {
        public string AadharNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> AllAddress { get; set; }
        public Address PrimaryAddress { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
