using SistemaPet.Core.DTOs;
using SistemaPet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.InputPorts
{
    public interface IPetService
    {
        public PetDto CreatePet(PetDto dto);

        public PetDto UpdatePet(PetDto dto);

        public PetDto DeletePet(PetDto dto);

        public string GetPetById(string id);

        public List<PetDto> GetAll();
    }
}
