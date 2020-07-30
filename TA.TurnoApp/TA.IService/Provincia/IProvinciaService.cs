using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Provincia.Dto;

namespace TA.IService.Provincia
{
    public interface IProvinciaService
    {
        ProvinciaDto Add(ProvinciaDto dto);

        ProvinciaDto Update(ProvinciaDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<ProvinciaDto> GetAll();

        IEnumerable<ProvinciaDto> GetAllFilter(string query);

        ProvinciaDto GetById(long id);
    }
}
