using System.Collections.Generic;
using System.Threading.Tasks;
using stream_proxy.Models;

namespace stream_proxy.Services
{
    public interface IStreamManagerService
    {
        public Task<ServiceResult<bool>> CreateDeviceStreamRequest();
    }
}
