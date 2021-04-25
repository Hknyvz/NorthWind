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
    public class RequestLogController : ControllerBase
    {
        IRequestLogBLL requestLogBLL;
        public RequestLogController(IRequestLogBLL requestLogBLL)
        {
            this.requestLogBLL = requestLogBLL;
        }

        [HttpGet]
        public IActionResult GetRequestLogs()
        {
            return Ok(requestLogBLL.GetRequestLogs());
        }
    }
}
