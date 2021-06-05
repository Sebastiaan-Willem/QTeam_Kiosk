using Microsoft.EntityFrameworkCore;
using QTeam_Kiosk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Data.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly QTeamContext _context;

        public AddressRepository(QTeamContext context)
        {
            _context = context;
        }

        public async Task<List<Address>> GetAddressesAsync()
        {
            return await _context.Addresses
                .ToListAsync();
        }

        public async Task<Address> GetAddressAsync(int id)
        {
            return await _context.Addresses
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAddressAsync(Address address)
        {
            await _context.Addresses.AddAsync(address);
            await _context.SaveChangesAsync();
        }
    }
}
