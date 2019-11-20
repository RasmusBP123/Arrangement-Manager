using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group15.EventManager.ApplicationLayer.Interfaces;
using Group15.EventManager.ApplicationLayer.ViewModels.Customers;
using Microsoft.AspNetCore.Mvc;

namespace Group15.EventManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerApplicationService _customerApplicationService;

        public CustomerController(ICustomerApplicationService customerApplicationService)
        {
            _customerApplicationService = customerApplicationService;
        }
         
        //REFACTOR -- Get customer out and replace it
      

        //[HttpPost]
        //[Route("event")]
        //public async Task<IActionResult> SignCustomerUpForEvent(Guid eventId, SignUpCustomerViewModel customerViewModel)
        //{
        //    if(customerViewModel != null && eventId != Guid.Empty)
        //    {
        //       await _customerApplicationService.SignCustomerUpForEvent(eventId, customerViewModel);
        //        return StatusCode(201);
        //    }

        //    return StatusCode(500);
        //}
    }
}