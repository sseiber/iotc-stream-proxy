using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using stream_proxy.Services;
using System;
using System.Collections.Generic;
using stream_proxy.Models;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace stream_proxy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuleController : ControllerBase
    {
        private readonly ILogger<ModuleController> logger;

        private readonly IModuleService moduleService;

        public ModuleController(ILogger<ModuleController> logger, IModuleService moduleService)
        {
            this.logger = logger;
            this.moduleService = moduleService;
        }

        [HttpGet("test")]
        public async Task<IActionResult> test()
        {
            this.logger.LogInformation("test");

            return Ok(await moduleService.test());
        }
    }
}
