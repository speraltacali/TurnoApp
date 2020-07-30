using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Domicilio.Dto;

namespace TA.IService.Domicilio
{
    public interface IDomicilioService
    {
        DomicilioDto Add(DomicilioDto dto);

        DomicilioDto Update(DomicilioDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<DomicilioDto> GetAll();

        IEnumerable<DomicilioDto> GetAllFilter(string query);

        DomicilioDto GetById(long id);
    }
}
