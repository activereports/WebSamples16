using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.ServiceProcess;

namespace PrintAgent
{
    public class GenericServiceHost : ServiceBase
    {
        private IHost _host;
        private bool _stopRequestedByWindows;

        public GenericServiceHost(IHost host)
        {
            _host = host ?? throw new ArgumentNullException(nameof(host));
        }

        protected sealed override void OnStart(string[] args)
        {
            _host
                .Services
                .GetRequiredService<IHostApplicationLifetime>()
                .ApplicationStopped
                .Register(() =>
                {
                    if (!_stopRequestedByWindows)
                    {
                        Stop();
                    }
                });

            _host.Start();
        }

        protected sealed override void OnStop()
        {
            _stopRequestedByWindows = true;
            try
            {
                _host.StopAsync().GetAwaiter().GetResult();
            }
            finally
            {
                _host.Dispose();
            }
        }
    }

    public static class GenericHostWindowsServiceExtensions
    {
        public static void RunAsService(this IHost host)
        {
            var hostService = new GenericServiceHost(host);
            ServiceBase.Run(hostService);
        }
    }
}