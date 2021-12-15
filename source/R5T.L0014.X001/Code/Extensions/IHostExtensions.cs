using System;
using System.Threading.Tasks;


namespace Microsoft.Extensions.Hosting
{
    public static class IHostExtensions
    {
        public static async Task RunAsync(this Task<IHost> gettingHost)
        {
            var host = await gettingHost;

            await host.RunAsync();
        }
    }
}