using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databind_ComboBox
{
    public class Address
    {
        public int DoorNo { get; set; }
        public string StreetName { get; set; }
        public string TownName { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }
        public string FullAddress
        {
            get
            {
                return $"{DoorNo}, {StreetName}, {TownName}, {District}, {State} - {PinCode}";
            }
        }
    }
}
