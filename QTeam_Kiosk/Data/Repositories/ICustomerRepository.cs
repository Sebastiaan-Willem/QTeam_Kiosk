using QTeam_Kiosk.DTO;
using QTeam_Kiosk.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Data.Repositories
{
    public interface ICustomerRepository
    {
        Task AddCustomerAsync(Customer customer);
        Task<Customer> GetCustomerAsync(int id);
        Task<List<Customer>> GetCustomersAsync();
    }
}