using AutoMapper;
using QTeam_Kiosk.Data.Repositories;
using QTeam_Kiosk.DTO;
using QTeam_Kiosk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Services
{
    public class AddressService
    {
        private IMapper _mapper;
        private IAddressRepository _repo;

        public AddressService(IMapper mapper, IAddressRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<List<Address>> GetAllAddressesAsync()
        {
            return await _repo.GetAddressesAsync();
        }

        public async Task<Address> GetAddressAsync(int id)
        {
            return await _repo.GetAddressAsync(id);
        }

        public async Task AddAddressAsync(CustomerDTO dto)
        {
            //ADD AUTOMAPPER
            var address = _mapper.Map<Address>(dto);

            //add address repo
            await _repo.AddAddressAsync(address);
        }
    }
}
