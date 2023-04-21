using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SistemaPet.Core.DTOs;
using SistemaPet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static void MapperService(IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Client, ClientDto>();
                cfg.CreateMap<Pet, PetDto>();

                cfg.CreateMap<ClientDto, Client>();
                cfg.CreateMap<PetDto, Pet>();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
