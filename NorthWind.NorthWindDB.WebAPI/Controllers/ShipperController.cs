using Microsoft.AspNetCore.Mvc;
using NorthWind.NorthWindDB.Entites.NorthWindEntities;
using NorthWind.NorthWindDB.WebAPI.NorthWindApi;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        NorthWindApiService northWindApiService;
        public ShipperController(NorthWindApiService northWindApiService)
        {
            this.northWindApiService = northWindApiService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
            {
                var responses = await northWindApiService.GetEntitiesAsync<Shippers>(id);
                return Ok(responses);
            }
            var response = await northWindApiService.GetEntityAsync<Shippers>(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] Shippers shipper)
        {
            return Ok(await northWindApiService.AddEntityAsync(shipper));
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] Shippers shipper)
        {
            return Ok(await northWindApiService.UpdateEntityAsync(shipper));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(await northWindApiService.DeleteEntityAsync<Shippers>(id));
        }
    }
}
