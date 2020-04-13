using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServiceProvider.Controllers
{
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet("api/health")]
        public ActionResult healthCheck() => Ok("Ok");
    }
}
