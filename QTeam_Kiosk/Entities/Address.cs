using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int  HouseNumber { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
       
    }
}
