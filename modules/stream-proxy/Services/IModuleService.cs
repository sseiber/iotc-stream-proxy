using System.Collections.Generic;
using System.Threading.Tasks;

namespace stream_proxy.Services
{
    public interface IModuleService
    {
        public Task<string> test();
    }
}
