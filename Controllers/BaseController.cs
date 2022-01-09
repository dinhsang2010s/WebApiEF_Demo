using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPIDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseController : ControllerBase
    {
        protected readonly ILogger<BaseController> logger;
        public BaseController(ILogger<BaseController> _logger)
        {
            logger = _logger;
        }

    }
}
