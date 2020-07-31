using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Entity.Entity;
using TA.Domain.Repository.Empresa;
using TA.Infraestructure.Repository.Empresa;
using TA.IService.Empresa;
using TA.IService.Empresa.Dto;

namespace TA.Service.Empresa
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _EmpresaRepository = new EmpresaRepository();

        public EmpresaDto Add(EmpresaDto dto)
        {
            var obj = new Domain.Entity.Entity.Empresa
            {
                Cuit = dto.Cuit,
                Descripcion = dto.Descripcion,
                InicioActividad = dto.InicioActividad,
                Mail = dto.Mail,
                Telefono = dto.Telefono,
                Imagen = dto.Imagen
            };

            _EmpresaRepository.Add(obj);
            Save();

            dto.Id = obj.Id;
            return dto;
        }

        public EmpresaDto Update(EmpresaDto dto)
        {
            var obj = _EmpresaRepository.GetById(dto.Id);

            if (obj != null)
            {
                obj.Cuit = dto.Cuit;
                obj.Descripcion = dto.Descripcion;
                obj.InicioActividad = dto.InicioActividad;
                obj.Mail = dto.Mail;
                obj.Telefono = dto.Telefono;
                obj.Imagen = dto.Imagen;

                _EmpresaRepository.Update(obj);
                Save();

                return dto;
            }
            else
            {
                return null;
            }
        }

        public void Delete(long id)
        {
            var obj = _EmpresaRepository.GetById(id);

            if(obj != null)
            {
                obj.Eliminado = true;

                _EmpresaRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<EmpresaDto> GetAll()
        {
            return _EmpresaRepository.GetAll()
                .Select(x=> new EmpresaDto
                {
                    Id = x.Id,
                    Cuit = x.Cuit,
                    Descripcion = x.Descripcion,
                    InicioActividad = x.InicioActividad,
                    Mail = x.Mail,
                    Eliminado = x.Eliminado,
                    Telefono = x.Telefono,
                    Imagen = x.Imagen
                }).ToList();
        }

        public IEnumerable<EmpresaDto> GetByFilter(string query)
        {
            return _EmpresaRepository.GetByFilter(x => x.Descripcion.Contains(query) ||
                                                     x.Cuit.Contains(query) && !x.Eliminado)
                  .Select(x => new EmpresaDto
                  {
                      Id = x.Id,
                      Cuit = x.Cuit,
                      Descripcion = x.Descripcion,
                      InicioActividad = x.InicioActividad,
                      Mail = x.Mail,
                      Eliminado = x.Eliminado,
                      Telefono = x.Telefono,
                      Imagen = x.Imagen
                  }).ToList();
        }

        public EmpresaDto GetById(long id)
        {
            var obj = _EmpresaRepository.GetById(id);

            if (obj != null)
            {
                return new EmpresaDto
                {
                    Id = obj.Id,
                    Cuit = obj.Cuit,
                    Descripcion = obj.Descripcion,
                    InicioActividad = obj.InicioActividad,
                    Mail = obj.Mail,
                    Eliminado = obj.Eliminado,
                    Telefono = obj.Telefono,
                    Imagen = obj.Imagen
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _EmpresaRepository.Save();
        }
    }
}
