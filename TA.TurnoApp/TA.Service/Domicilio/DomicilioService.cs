using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.Domicilio;
using TA.Infraestructure.Repository.Domicilio;
using TA.IService.Domicilio;
using TA.IService.Domicilio.Dto;

namespace TA.Service.Domicilio
{
    public class DomicilioService : IDomicilioService
    {
        private readonly IDomicilioRepository _domicilioRepository = new DomicilioRepository();
        public DomicilioDto Add(DomicilioDto dto)
        {
            var obj = new Domain.Entity.Entity.Domicilio
            {
                Calle = dto.Calle,
                Numero = dto.Numero,
                Manzana = dto.Manzana,
                Piso = dto.Piso,
                NumDepartamento = dto.NumDepartamento,
                Eliminado = dto.Eliminado,
                LocalidadId = dto.LocalidadId
            };

            _domicilioRepository.Add(obj);
            Save();

            dto.Id = obj.Id;
            return dto;
        }

        public DomicilioDto Update(DomicilioDto dto)
        {
            var obj = _domicilioRepository.GetById(dto.Id);

            if (obj != null)
            {
                obj.Calle = dto.Calle;
                obj.Numero = dto.Numero;
                obj.Manzana = dto.Manzana;
                obj.Piso = dto.Piso;
                obj.NumDepartamento = dto.NumDepartamento;
                obj.LocalidadId = dto.LocalidadId;

                _domicilioRepository.Update(obj);
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
            var obj = _domicilioRepository.GetById(id);

            if(obj != null)
            {
                obj.Eliminado = true;

                _domicilioRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<DomicilioDto> GetAll()
        {
            return _domicilioRepository.GetAll()
                .Select(x => new DomicilioDto
                {
                    Id = x.Id,
                    Calle = x.Calle,
                    Numero = x.Numero,
                    Manzana = x.Manzana,
                    Piso = x.Piso,
                    NumDepartamento = x.NumDepartamento,
                    Eliminado = x.Eliminado,
                    LocalidadId = x.LocalidadId
                }).ToList();
        }

        public IEnumerable<DomicilioDto> GetByFilter(string query)
        {
            return _domicilioRepository.GetByFilter(x => x.Calle.Contains(query)
                            || x.Numero.Contains(query) && !x.Eliminado)
                .Select(x => new DomicilioDto
                {
                    Id = x.Id,
                    Calle = x.Calle,
                    Numero = x.Numero,
                    Manzana = x.Manzana,
                    Piso = x.Piso,
                    NumDepartamento = x.NumDepartamento,
                    Eliminado = x.Eliminado,
                    LocalidadId = x.LocalidadId
                }).ToList();
        }

        public DomicilioDto GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _domicilioRepository.Save();
        }
    }
}
