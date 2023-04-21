using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaPet.Core.DTOs;
using SistemaPet.Core.InputPorts;
using System;

namespace SistemaPet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpPost]
        public IActionResult CreatePet(PetDto dto)
        {
            try
            {
                var pet = _petService.CreatePet(dto);

                return StatusCode(201, new
                {
                    message = "Animal cadastrado com sucesso",
                    pet
                });
            }
            catch (ArgumentException e)
            {
                return StatusCode(400, new
                {
                    error = e.Message
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    error = e.Message
                });
            }
        }
    }
}
