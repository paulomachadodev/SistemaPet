using SistemaPet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.DTOs
{
    public class PetDto
    {
        public string? Nome { get; set; }
        public string? Type { get; set; }
        public string? Breed { get; set; }
    }
}
