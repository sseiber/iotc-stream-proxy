using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using stream_proxy.Models;
using Microsoft.Extensions.Logging;

namespace stream_proxy.Services
{
    public class StreamManagerService : IStreamManagerService
    {
        private readonly ILogger<StreamManagerService> logger;

        public StreamManagerService(ILogger<StreamManagerService> logger)
        {
            this.logger = logger;
        }

        public async Task<ServiceResult<bool>> CreateDeviceStreamRequest()
        {
            this.logger.LogInformation("CreateDeviceStreamRequest");

            await Task.Delay(500);

            ServiceResult<bool> serviceResult = new ServiceResult<bool>();
            serviceResult.Data = true;
            serviceResult.Success = true;
            serviceResult.Message = "The service call succeeded";

            return serviceResult;
        }
    }
}
