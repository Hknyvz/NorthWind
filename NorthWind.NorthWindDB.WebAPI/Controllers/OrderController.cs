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
    public class OrderController : ControllerBase
    {
        NorthWindApiService northWindApiService;
        public OrderController(NorthWindApiService northWindApiService)
        {
            this.northWindApiService = northWindApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
            {
                var responses = await northWindApiService.GetEntitiesAsync<Orders>();
                return Ok(responses);
            }
            var response = await northWindApiService.GetEntityAsync<Orders>(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Orders order)
        {
            return StatusCode(await northWindApiService.AddEntityAsync(order));
        }
        [HttpPut]
        public async Task<IActionResult> Update(Orders order)
        {
            
            return StatusCode(await northWindApiService.UpdateEntityAsync(order));
        }
        [HttpDelete]
        public async Task Delete(string id)
        {
            await northWindApiService.DeleteEntityAsync<Orders>(id);
        }
    }
}
