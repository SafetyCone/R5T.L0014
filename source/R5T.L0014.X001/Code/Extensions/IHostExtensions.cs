using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;


namespace System
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