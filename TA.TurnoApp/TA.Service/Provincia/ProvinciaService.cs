using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.Provincia;
using TA.Infraestructure.Repository.Provincia;
using TA.IService.Provincia;
using TA.IService.Provincia.Dto;

namespace TA.Service.Provincia
{
    public class ProvinciaService : IProvinciaService
    {
        private readonly IProvinciaRepository _provinciaRepository = new ProvinciaRepository();

        public ProvinciaDto Add(ProvinciaDto dto)
        {
            var obj = new Domain.Entity.Entity.Provincia()
            {
                Descripcion = dto.Descripcion,
                Eliminado = dto.Eliminado,
                PaisId = dto.PaisId
            };

            _provinciaRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public ProvinciaDto Update(ProvinciaDto dto)
        {
            var obj = _provinciaRepository.GetById(dto.Id);

            if(obj != null)
            {
                obj.Descripcion = dto.Descripcion;
                obj.Eliminado = dto.Eliminado;
                obj.PaisId = dto.PaisId;

                _provinciaRepository.Update(obj);
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
            var obj = _provinciaRepository.GetById(id);

            if (obj != null)
            {
                obj.Eliminado = true;

                _provinciaRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<ProvinciaDto> GetAll()
        {
            return _provinciaRepository.GetAll()
                .Select(x => new ProvinciaDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado,
                    PaisId = x.PaisId
                }).ToList();
        }

        public IEnumerable<ProvinciaDto> GetByFilter(string query)
        {
             return _provinciaRepository.GetByFilter(x=> x.Descripcion.Contains(query)
                            && x.Eliminado != true)
                .Select(x => new ProvinciaDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado,
                    PaisId = x.PaisId
                }).ToList();
        }

        public ProvinciaDto GetById(long id)
        {
            var obj = _provinciaRepository.GetById(id);

            if (obj != null)
            {
                return new ProvinciaDto()
                {
                    Id = obj.Id,
                    Descripcion = obj.Descripcion,
                    Eliminado = obj.Eliminado,
                    PaisId = obj.PaisId
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _provinciaRepository.Save();
        }

    }
}
