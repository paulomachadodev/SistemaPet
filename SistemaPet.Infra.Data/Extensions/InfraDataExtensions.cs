using Microsoft.Extensions.DependencyInjection;
using SistemaPet.Core.InputPorts;
using SistemaPet.Core.OutputPorts;
using SistemaPet.Core.Services;
using SistemaPet.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Infra.Data.Extensions
{
    public static class InfraDataExtensions
    {
        public static IServiceCollection AddInfraDataClientRepository(this IServiceCollection service)
        {
            service.AddScoped<IClienteRepository, ClientRepository>();
            service.AddScoped<IPetRepository, PetRepository>();

            return service;
        }
    }
}
