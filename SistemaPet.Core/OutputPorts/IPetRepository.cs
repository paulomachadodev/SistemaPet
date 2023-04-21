using SistemaPet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.OutputPorts
{
    public interface IPetRepository
    {
        public Pet CreatePet(Pet pet);

        public Pet UpdatePet(Pet pet);

        public Pet DeletePet(string id);

        public string GetPetById(string id);

        public List<Pet> GetAll();
    }
}
