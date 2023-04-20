using SistemaPet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.DTOs
{
    public class ClientDto
    {
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public string? Phone { get; set; }
    }
}
