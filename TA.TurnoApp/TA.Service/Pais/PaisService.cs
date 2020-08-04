using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Schema;
using TA.Domain.Repository.Pais;
using TA.Infraestructure.Repository.Pais;
using TA.IService.Pais;
using TA.IService.Pais.Dto;
using TA.IService.Reserva_Turno.Dto;

namespace TA.Service.Pais
{
    public class PaisService : IPaisService
    {

        private readonly IPaisRepository _paisRepository = new PaisRepository();

        public PaisDto Add(PaisDto dto)
        {
            var obj = new Domain.Entity.Entity.Pais()
            {
                Descripcion = dto.Descripcion,
                Eliminado = dto.Eliminado
            };

            _paisRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public PaisDto Update(PaisDto dto)
        {
            var obj = _paisRepository.GetById(dto.Id);

            if(obj != null)
            {
                obj.Descripcion = dto.Descripcion;

                _paisRepository.Update(obj);
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
            var obj = _paisRepository.GetById(id);

            if (obj != null)
            {
                obj.Eliminado = true;

                _paisRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<PaisDto> GetAll()
        {
            return _paisRepository.GetAll()
                .Select(x => new PaisDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado
                }).ToList();
        }

        public IEnumerable<PaisDto> GetByFilter(string query)
        {
            return _paisRepository.GetByFilter(x => x.Descripcion.Contains(query)
                          && x.Eliminado != true)
                .Select(x => new PaisDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado
                }).ToList();
        }

        public PaisDto GetById(long id)
        {
            var obj = _paisRepository.GetById(id);

            if (obj != null)
            {
                return new PaisDto()
                {
                    Id = obj.Id,
                    Descripcion = obj.Descripcion,
                    Eliminado = obj.Eliminado
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _paisRepository.Save();
        }

    }
}
