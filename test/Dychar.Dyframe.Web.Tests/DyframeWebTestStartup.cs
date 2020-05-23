using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Dychar.Dyframe
{
    public class DyframeWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<DyframeWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}