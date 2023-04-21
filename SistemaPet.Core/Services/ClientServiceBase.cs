﻿using AutoMapper;
using SistemaPet.Core.DTOs;
using SistemaPet.Core.Entities;
using SistemaPet.Core.InputPorts;
using SistemaPet.Core.OutputPorts;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.Services
{
    public class ClientServiceBase : IClientService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClientServiceBase(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public ClientDto CreateClient(ClientDto dto)
        {
            var client = _mapper.Map<Client>(dto);

            _clienteRepository.CreateClient(client);

            return _mapper.Map<ClientDto>(client);
        }

        public ClientDto DeleteClient(ClientDto dto)
        {
            throw new NotImplementedException();
        }

        public List<ClientDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public string GetClientById(string id)
        {
            throw new NotImplementedException();
        }

        public ClientDto UpdateClient(ClientDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
