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
        public ClientDto CreateClient(ClientDto client);

        public ClientDto UpdateClient(ClientDto client);

        public ClientDto DeleteClient(ClientDto client);

        public string GetClientById(string id);

        public List<Client> GetAll();
    }
}
