using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Empresa_Domicilio.Dto;

namespace TA.IService.Empresa_Domicilio
{
    public interface IEmpresa_DomicilioService
    {
        Empresa_DomicilioDto Add(Empresa_DomicilioDto dto);

        Empresa_DomicilioDto Update(Empresa_DomicilioDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<Empresa_DomicilioDto> GetAll();

        IEnumerable<Empresa_DomicilioDto> GetAllFilter(string query);

        Empresa_DomicilioDto GetById(long id);
    }
}
