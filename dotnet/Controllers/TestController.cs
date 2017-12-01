using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [Route("api")]
    public class TestController : Controller
    {
        // GET api/values/5
        [HttpGet("static")]
        public FileResult GetStaticFile()
        {
            return base.File("~/staticfile.txt", "text/plain");
        }
    }
}
