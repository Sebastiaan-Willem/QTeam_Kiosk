using Microsoft.AspNetCore.Mvc;
using QTeam_Kiosk.DTO;
using QTeam_Kiosk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTeam_Kiosk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> GetAllCustomers()
        {
            var customers = await _service.GetAllCustomersAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> GetCustomer(int id)
        {
            var customer = await _service.GetCustomerAsync(id);
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult> AddCustomer(CustomerDTO dto)
        {
            await _service.AddCustomerAsync(dto);
            return Ok("User Added");
        }

    }
}
