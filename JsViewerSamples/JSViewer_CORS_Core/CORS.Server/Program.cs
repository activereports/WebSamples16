using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace JSViewer_CORS_Core
{
    class Program
    {
        public static void Main(string[] args) => BuildWebHost(args).Run();

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}