using SistemaPet.Core.Entities;
using SistemaPet.Core.OutputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Infra.Data.Repositories
{
    public class ClientRepository : IClienteRepository
    {
        public Client CreateClient(Client client)
        {
            return new Client();
        }

        public Client DeleteClient(string id)
        {
            return new Client();
        }

        public List<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public string GetClientById(string id)
        {
            throw new NotImplementedException();
        }

        public Client UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
