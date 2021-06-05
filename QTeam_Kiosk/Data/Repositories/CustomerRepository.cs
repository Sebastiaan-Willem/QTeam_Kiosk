using Microsoft.EntityFrameworkCore;
using QTeam_Kiosk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly QTeamContext _context;

        public CustomerRepository(QTeamContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _context.Customers
                //.Include(x => x.Address)
                .ToListAsync();
        }

        public async Task<Customer> GetCustomerAsync(int id)
        {
            return await _context.Customers
                //.Include(x => x.Address)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

    }
}
