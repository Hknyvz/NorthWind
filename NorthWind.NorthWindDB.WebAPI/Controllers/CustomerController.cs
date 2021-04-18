using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthWind.NorthWindDB.Entites.NorthWindEntities;
using NorthWind.NorthWindDB.WebAPI.NorthWindApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        NorthWindApiService northWindApiService;
        public CustomerController(NorthWindApiService northWindApiService)
        {
            this.northWindApiService = northWindApiService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
            {
                var responses = await northWindApiService.GetEntitiesAsync<Customers>(id);
                return Ok(responses);
            }
            var response = await northWindApiService.GetEntityAsync<Customers>(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Customers customer)
        {
            return StatusCode(await northWindApiService.AddEntityAsync(customer));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Customers customer)
        {
            return StatusCode(await northWindApiService.UpdateEntityAsync(customer));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            return StatusCode(await northWindApiService.DeleteEntityAsync<Customers>(id));
        }
    }
}
