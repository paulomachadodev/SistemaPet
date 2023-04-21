using SistemaPet.Core.Entities;
using SistemaPet.Core.OutputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Infra.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        public Pet CreatePet(Pet pet)
        {
            return new Pet();
        }

        public Pet DeletePet(string id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public string GetPetById(string id)
        {
            throw new NotImplementedException();
        }

        public Pet UpdatePet(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}
