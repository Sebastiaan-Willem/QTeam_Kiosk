using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LicencePlate { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public bool SubscribedToUpdates { get; set; }

        //public int AddressId { get; set; }
        //public Address Address { get; set; }
    }
}
