using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Pais.Dto;

namespace TA.IService.Pais
{
    public interface IPaisService
    {
        PaisDto Add(PaisDto dto);

        PaisDto Update(PaisDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<PaisDto> GetAll();

        IEnumerable<PaisDto> GetByFilter(string query);

        PaisDto GetById(long id);
    }
}
