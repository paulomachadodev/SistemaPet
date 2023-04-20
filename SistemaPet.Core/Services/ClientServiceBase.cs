using AutoMapper;
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

        public ClientDto CreateClient(ClientDto client)
        {
            var newClient = _mapper.Map<Client>(client);

            _clienteRepository.CreateClient(newClient);

            return _mapper.Map<ClientDto>(newClient);
        }

        public ClientDto DeleteClient(ClientDto client)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public string GetClientById(string id)
        {
            throw new NotImplementedException();
        }

        public ClientDto UpdateClient(ClientDto client)
        {
            throw new NotImplementedException();
        }
    }
}
