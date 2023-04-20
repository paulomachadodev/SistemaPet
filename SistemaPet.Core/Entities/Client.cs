using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.Entities
{
    public class Client
    {
        public Client() 
        { 
            Id = Guid.NewGuid().ToString();
            DateTimeCreation = DateTime.Now;
        }

        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public string? Phone { get; set; }
        public DateTime? DateTimeCreation { get; set; }
    }
}
