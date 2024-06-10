using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databind_ComboBox
{
    public class CitizenModel
    {
        public CitizenModel()
        {
            SetTemporaryAddress();
            SetTemporaryCitizen();
        }

        public List<Citizen> CitizenCollection
        {
            get
            {
                return citizenCollection;
            }
        }

        public Citizen SelectedCitizen
        {
            set
            {
                selectedCitizen = value;
            }
            get
            {
                return selectedCitizen;
            }
        }

        public Address SelectedAddress
        {
            get; set;
        }


        private Citizen selectedCitizen;
        private List<Citizen> citizenCollection;
        private List<Address> AddressCollection;

        public void SetTemporaryAddress()
        {
            AddressCollection = new List<Address>()
            {
                new Address()
                {
                    DoorNo = 32,
                    StreetName = "Anna Nagar",
                    TownName = "Sirumugai",
                    District = "Coimbatore",
                    State = "Tamilnadu",
                    PinCode = 641302
                },
                new Address()
                {
                    DoorNo = 12,
                    StreetName = "Jeeva Nagar",
                    TownName = "Mettupalayam",
                    District = "Coimbatore",
                    State = "Tamilnadu",
                    PinCode = 123456
                },
                new Address()
                {
                    DoorNo = 32,
                    StreetName = "Rayan Nagar",
                    TownName = "Illuppanatham",
                    District = "Coimbatore",
                    State = "Tamilnadu",
                    PinCode = 234567
                },
                new Address()
                {
                    DoorNo = 32,
                    StreetName = "VOC Nagar",
                    TownName = "Irumbarai",
                    District = "Coimbatore",
                    State = "Tamilnadu",
                    PinCode = 345678
                },
                new Address()
                {
                    DoorNo = 32,
                    StreetName = "Gandhi Nagar",
                    TownName = "Annur",
                    District = "Coimbatore",
                    State = "Tamilnadu",
                    PinCode = 456789
                },
                new Address()
                {
                    DoorNo = 32,
                    StreetName = "Periyar Nagar",
                    TownName = "Lingapuram",
                    District = "Coimbatore",
                    State = "Tamilnadu",
                    PinCode = 567890
                },
            };
        }

        public void SetTemporaryCitizen()
        {
            citizenCollection = new List<Citizen>()
            {
               new Citizen()
               {
                   AadharNumber = "689190479610",
                   FirstName = "Pugazhenthi",
                   LastName = "Thaniarasu",
                   PrimaryAddress = AddressCollection[0],
                   AllAddress = new List<Address>()
                   {
                       AddressCollection[0],
                       AddressCollection[1]
                   }
               },
               new Citizen()
               {
                   AadharNumber = "111111111111",
                   FirstName = "Pradeep",
                   LastName = "Pranav",
                   PrimaryAddress = AddressCollection[2],
                   AllAddress = new List<Address>()
                   {
                       AddressCollection[2],
                       AddressCollection[3]
                   }
               },
               new Citizen()
               {
                   AadharNumber = "999999999999",
                   FirstName = "Gokulraj",
                   LastName = "K",
                   PrimaryAddress = AddressCollection[4],
                   AllAddress = new List<Address>()
                   {
                       AddressCollection[4],
                       AddressCollection[5]
                   }
               },
            };
        }
    }
}
