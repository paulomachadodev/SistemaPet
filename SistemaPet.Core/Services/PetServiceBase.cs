using AutoMapper;
using SistemaPet.Core.DTOs;
using SistemaPet.Core.Entities;
using SistemaPet.Core.InputPorts;
using SistemaPet.Core.OutputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPet.Core.Services
{
    public class PetServiceBase : IPetService
    {
        private readonly IPetRepository _petRepository;
        private readonly IMapper _mapper;

        public PetServiceBase(IPetRepository petRepository, IMapper mapper)
        {
            _petRepository = petRepository;
            _mapper = mapper;
        }

        public PetDto CreatePet(PetDto dto)
        {
            var pet = _mapper.Map<Pet>(dto);

            _petRepository.CreatePet(pet);

            return _mapper.Map<PetDto>(pet);
        }

        public PetDto DeletePet(PetDto dto)
        {
            throw new NotImplementedException();
        }

        public List<PetDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public string GetPetById(string id)
        {
            throw new NotImplementedException();
        }

        public PetDto UpdatePet(PetDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
