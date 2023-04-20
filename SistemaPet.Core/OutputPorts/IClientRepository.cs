using SistemaPet.Core.DTOs;
using SistemaPet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.OutputPorts
{
    public interface IClienteRepository
    {
        public Client CreateClient(Client client);

        public Client UpdateClient(Client client);

        public Client DeleteClient(string id);

        public string GetClientById(string id);

        public List<Client> GetAll();
    }
}
