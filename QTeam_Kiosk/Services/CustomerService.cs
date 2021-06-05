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
    public class CustomerService : ICustomerService
    {
        private IMapper _mapper;
        private ICustomerRepository _customerRepo;
        private IAddressRepository _addressRepo;

        public CustomerService(IMapper mapper, ICustomerRepository repo)
        {
            _mapper = mapper;
            _customerRepo = repo;
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _customerRepo.GetCustomersAsync();
        }

        public async Task<Customer> GetCustomerAsync(int id)
        {
            return await _customerRepo.GetCustomerAsync(id);
        }

        public async Task AddCustomerAsync(CustomerDTO dto)
        {
            //ADD AUTOMAPPER
            var customer = _mapper.Map<Customer>(dto);
            var address = _mapper.Map<Address>(dto);

            //add address repo
            await _addressRepo.AddAddressAsync(address);
            await _customerRepo.AddCustomerAsync(customer);
        }
    }
}
