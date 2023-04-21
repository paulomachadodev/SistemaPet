using SistemaPet.Core.DTOs;
using SistemaPet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.InputPorts
{
    public interface IClientService
    {
        public ClientDto CreateClient(ClientDto dto);

        public ClientDto UpdateClient(ClientDto dto);

        public ClientDto DeleteClient(ClientDto dto);

        public string GetClientById(string id);

        public List<ClientDto> GetAll();
    }
}
