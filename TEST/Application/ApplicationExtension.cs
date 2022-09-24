using Application.IService;
using Application.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public static class ApplicationExtension
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
          
            addServices(services);
        }

        public static void addServices(IServiceCollection services)
        {
            services.AddScoped<IProcessFileService, ProcessFileService>();
        }
    }
}
