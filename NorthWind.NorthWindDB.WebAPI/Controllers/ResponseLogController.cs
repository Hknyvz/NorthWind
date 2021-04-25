using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthWind.NorthWindDB.BLL.LogManager.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseLogController : ControllerBase
    {
        IResponseLogBLL responseLogBLL;
        public ResponseLogController(IResponseLogBLL responseLogBLL)
        {
            this.responseLogBLL = responseLogBLL;
        }

        [HttpGet]
        public IActionResult GetRequestLogs()
        {
            return Ok(responseLogBLL.GetResponseLogs());
        }
    }
}
