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
    namespace stream_proxy.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class StreamManagerController : ControllerBase
        {
            private readonly ILogger<StreamManagerController> logger;

            private readonly IStreamManagerService streamManagerService;

            public StreamManagerController(ILogger<StreamManagerController> logger, IStreamManagerService streamManagerService)
            {
                this.logger = logger;
                this.streamManagerService = streamManagerService;
            }

            [HttpGet("test")]
            public async Task<IActionResult> CreateDeviceStreamRequest()
            {
                this.logger.LogInformation("CreateDeviceStreamRequest");

                var result = this.streamManagerService.CreateDeviceStreamRequest();

                return Ok(await result);
            }
        }
    }
}
