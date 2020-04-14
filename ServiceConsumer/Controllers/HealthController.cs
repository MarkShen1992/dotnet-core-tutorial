using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServiceConsumer.Controllers
{
    public class HealthController : ControllerBase
    {
        [HttpGet("api/health")]
        public ActionResult healthCheck() => Ok("Ok");
    }
}
