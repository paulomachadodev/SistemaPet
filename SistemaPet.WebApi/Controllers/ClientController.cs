using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaPet.Core.DTOs;
using SistemaPet.Core.InputPorts;
using SistemaPet.Core.OutputPorts;
using System;

namespace SistemaPet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clienteService;

        public ClientController(IClientService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult CreateClient(ClientDto dto)
        {
            try
            {
                var client = _clienteService.CreateClient(dto);

                return StatusCode(201, new
                {
                    message = "Cliente cadastrado com sucesso",
                    client
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
