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
        public async Task<IActionResult> Get(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                var responses = await northWindApiService.GetEntitiesAsync<Customers>();
                return Ok(responses);
            }
            var response = await northWindApiService.GetEntityAsync<Customers>(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Customers customer)
        {
            return StatusCode(await northWindApiService.AddEntityAsync(customer));
        }
        [HttpPut]
        public async Task<IActionResult> Update(Customers customer)
        {
            return StatusCode(await northWindApiService.UpdateEntityAsync(customer));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            return StatusCode(await northWindApiService.DeleteEntityAsync<Customers>(id));
        }
    }
}
