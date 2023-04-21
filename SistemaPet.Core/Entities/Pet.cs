using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.Entities
{
    public class Pet
    {
        public Pet() 
        { 
            Id = Guid.NewGuid().ToString();
            DateTimeCreation = DateTime.Now;
            Status = true;
        }
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Type { get; set; }
        public string? Breed { get; set; }
        public bool Status { get; set; }
        public DateTime DateTimeCreation { get; set; }
        public Client? Client { get; set; }
    }
}
