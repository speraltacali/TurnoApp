using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TA.IService.Empresa;
using TA.IService.Empresa.Dto;
using TA.Service.Empresa;

namespace TurnosServicesAPI.Controllers.Empresa
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _empresaService = new EmpresaService();

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Empresa = await Task.Run(() =>
            {
                return _empresaService.GetByFilter(string.Empty);
            });

            if(Empresa == null)
            {
                return NotFound();
            }

            return Ok(Empresa);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Empresa = await Task.Run(() =>
            {
                return _empresaService.GetById(id);
            });

            if (Empresa == null)
            {
                return NotFound();
            }

            return Ok(Empresa);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmpresaDto empresa)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Empresa = await Task.Run(() =>
            {
                return _empresaService.Add(empresa);
            });

            if(Empresa == null)
            {
                return NotFound();
            }

            return Ok(Empresa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] long id ,[FromBody] EmpresaDto empresa)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(id != empresa.Id)
            {
                return BadRequest();
            }

            var Empresa = await Task.Run(() =>
            {
                return _empresaService.Update(empresa);
            });

            try
            {
                return Ok(Empresa);
            }
            catch (DbUpdateConcurrencyException)
            {
                var validation = _empresaService.GetById(Empresa.Id);

                if(validation == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Empresa = await Task.Run(() =>
            {
                return _empresaService.GetById(id);
            });

            if(Empresa == null)
            {
                return NotFound();
            }

            _empresaService.Delete(Empresa.Id);

            return Ok(Empresa);

        }
    }
}
