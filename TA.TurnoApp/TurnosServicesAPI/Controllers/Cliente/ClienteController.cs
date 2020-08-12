using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TA.IService.Cliente;
using TA.IService.Cliente.Dto;
using TA.Service.Cliente;

namespace TurnosServicesAPI.Controllers.Cliente
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService = new ClienteService();

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Cliente = await Task.Run(() =>
            {
                return _clienteService.GetByFilter(string.Empty);
            });

            if(Cliente == null)
            {
                return NotFound();
            }

            return Ok(Cliente);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] long id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Cliente = await Task.Run(() =>
            {
                return _clienteService.GetById(id);
            });

            if(Cliente == null)
            {
                return NotFound();
            }

            return Ok(Cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClienteDto cliente)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Cliente = await Task.Run(() =>
            {
                return _clienteService.Add(cliente);
            });

            if(Cliente == null)
            {
                return NotFound();
            }

            return Ok(Cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] long id ,[FromBody] ClienteDto cliente)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(id != cliente.Id)
            {
                return BadRequest();
            }

            var Cliente = await Task.Run(() =>
            {
                return _clienteService.Update(cliente);
            });

            if(Cliente == null)
            {
                return NotFound();
            }

            return Ok(Cliente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Cliente = await Task.Run(() =>
            {
                return _clienteService.GetById(id);
            });

            if(Cliente == null)
            {
                return NotFound();
            }

            _clienteService.Delete(Cliente.Id);

            return Ok(Cliente);
        }
    }
}
