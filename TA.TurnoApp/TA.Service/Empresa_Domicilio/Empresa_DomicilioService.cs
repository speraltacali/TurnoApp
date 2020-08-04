using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using TA.Domain.Repository.Empresa_Domicilio;
using TA.Infraestructure.Repository.Empresa_Domicilio;
using TA.IService.Empresa_Domicilio;
using TA.IService.Empresa_Domicilio.Dto;

namespace TA.Service.Empresa_Domicilio
{
    public class Empresa_DomicilioService : IEmpresa_DomicilioService
    {

        private readonly IEmpresa_DomicilioRepository _empresa_DomicilioRepository = new Empresa_DomicilioRepository();
        public Empresa_DomicilioDto Add(Empresa_DomicilioDto dto)
        {
            var obj = new Domain.Entity.Entity.Empresa_Domicilio()
            {
                EmpresaId = dto.EmpresaId,
                DomicilioId = dto.DomicilioId
            };

            _empresa_DomicilioRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public Empresa_DomicilioDto Update(Empresa_DomicilioDto dto)
        {
            var obj = _empresa_DomicilioRepository.GetById(dto.Id);

            if(obj != null)
            {
                obj.DomicilioId = dto.DomicilioId;
                obj.EmpresaId = dto.EmpresaId;

                _empresa_DomicilioRepository.Update(obj);
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
            var obj = _empresa_DomicilioRepository.GetById(id);

            if (obj != null)
            {
                _empresa_DomicilioRepository.Delete(obj);
                Save();
            }
        }

        public IEnumerable<Empresa_DomicilioDto> GetAll()
        {
            return _empresa_DomicilioRepository.GetAll()
                .Select(x => new Empresa_DomicilioDto()
                {
                    Id = x.Id,
                    DomicilioId = x.DomicilioId,
                    EmpresaId = x.EmpresaId
                }).ToList();
        }

        public IEnumerable<Empresa_DomicilioDto> GetByFilter(string query)
        {
            return _empresa_DomicilioRepository.GetByFilter(x=> x.Domicilio.Calle.Contains(query) ||
                            x.Empresa.Descripcion.Contains(query))
                .Select(x => new Empresa_DomicilioDto()
                {
                    Id = x.Id,
                    DomicilioId = x.DomicilioId,
                    EmpresaId = x.EmpresaId
                }).ToList();
        }

        public Empresa_DomicilioDto GetById(long id)
        {
            var obj = _empresa_DomicilioRepository.GetById(id);

            if (obj != null)
            {
                return new Empresa_DomicilioDto()
                {
                    Id = obj.Id,
                    DomicilioId = obj.DomicilioId,
                    EmpresaId = obj.EmpresaId
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _empresa_DomicilioRepository.Save();
        }

    }
}
