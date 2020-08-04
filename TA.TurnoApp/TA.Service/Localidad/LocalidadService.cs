using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.Localidad;
using TA.Infraestructure.Repository.Localidad;
using TA.IService.Localidad;
using TA.IService.Localidad.Dto;

namespace TA.Service.Localidad
{
    public class LocalidadService : ILocalidadService
    {
        private readonly ILocalidadRepository _localidadRepository = new LocalidadRepository();

        public LocalidadDto Add(LocalidadDto dto)
        {
            var obj = new Domain.Entity.Entity.Localidad()
            {
                Descripcion = dto.Descripcion,
                Eliminado = dto.Eliminado,
                ProvinciaId = dto.ProvinciaId
            };

            _localidadRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public LocalidadDto Update(LocalidadDto dto)
        {
            var obj = _localidadRepository.GetById(dto.Id);

            if(obj != null)
            {
                obj.Descripcion = dto.Descripcion;
                obj.ProvinciaId = dto.ProvinciaId;

                _localidadRepository.Update(obj);
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
            var obj = _localidadRepository.GetById(id);

            if (obj != null)
            {
                obj.Eliminado = true;
                
                _localidadRepository.Update(obj);
                Save();
             
            }
        }

        public IEnumerable<LocalidadDto> GetAll()
        {
            return _localidadRepository.GetAll()
                .Select(x => new LocalidadDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado,
                    ProvinciaId = x.ProvinciaId
                }).ToList();
        }

        public IEnumerable<LocalidadDto> GetByFilter(string query)
        {
            return _localidadRepository.GetByFilter(X => X.Descripcion.Contains(query)
              && X.Eliminado != true)
                .Select(x => new LocalidadDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado,
                    ProvinciaId = x.ProvinciaId
                }).ToList();
        }

        public LocalidadDto GetById(long id)
        {
            var obj = _localidadRepository.GetById(id);

            if (obj != null)
            {
                return new LocalidadDto()
                {
                    Id = obj.Id,
                    Descripcion = obj.Descripcion,
                    Eliminado = obj.Eliminado,
                    ProvinciaId = obj.ProvinciaId
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _localidadRepository.Save();
        }
    }
}
