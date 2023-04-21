using Microsoft.Extensions.DependencyInjection;
using SistemaPet.Core.InputPorts;
using SistemaPet.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.Extensions
{
    public static class CoreExtensions
    {
        public static IServiceCollection AddCoreClientService(this IServiceCollection service)
        {
            service.AddScoped<IClientService, ClientServiceBase>();
            service.AddScoped<IPetService, PetServiceBase>();

            return service;
        }
    }
}