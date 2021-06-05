using AutoMapper;
using QTeam_Kiosk.DTO;
using QTeam_Kiosk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerDTO>()
                .ReverseMap();
            CreateMap<Address, CustomerDTO>()
                .ReverseMap();
        }
    }
}
