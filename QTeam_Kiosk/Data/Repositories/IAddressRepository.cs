using QTeam_Kiosk.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Data.Repositories
{
    public interface IAddressRepository
    {
        Task AddAddressAsync(Address address);
        Task<Address> GetAddressAsync(int id);
        Task<List<Address>> GetAddressesAsync();
    }
}