using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TA.IService.Domicilio;
using TA.IService.Domicilio.Dto;
using TA.Service.Domicilio;

namespace TurnosServicesAPI.Controllers.Domicilio
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomicilioController : ControllerBase
    {
        private readonly IDomicilioService _domicilioService = new DomicilioService();

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Domicilio = await Task.Run(() =>
            {
                return _domicilioService.GetByFilter(string.Empty);
            });

            if (Domicilio == null)
            {
                return NotFound();
            }

            return Ok(Domicilio);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Domicilio = await Task.Run(() =>
            {
                return _domicilioService.GetById(id);
            });

            if (Domicilio == null)
            {
                return NotFound();
            }

            return Ok(Domicilio);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DomicilioDto domicilio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Domicilio = await Task.Run(() =>
            {
                return _domicilioService.Add(domicilio);
            });

            if (Domicilio == null)
            {
                return NotFound();
            }

            return Ok(Domicilio);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] long id ,[FromBody] DomicilioDto domicilio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(id != domicilio.Id)
            {
                return BadRequest();
            }

            var Domicilio = await Task.Run(() =>
            {
                return _domicilioService.Update(domicilio);
            });

            if (Domicilio == null)
            {
                return NotFound();
            }

            return Ok(Domicilio);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Post([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Domicilio = await Task.Run(() =>
            {
                return _domicilioService.GetById(id);
            });

            if (Domicilio == null)
            {
                return NotFound();
            }

            _domicilioService.Delete(Domicilio.Id);

            return Ok(Domicilio);
        }
    }
}
