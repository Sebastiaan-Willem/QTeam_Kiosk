using QTeam_Kiosk.DTO;
using QTeam_Kiosk.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Services
{
    public interface ICustomerService
    {
        Task AddCustomerAsync(CustomerDTO dto);
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerAsync(int id);
    }
}