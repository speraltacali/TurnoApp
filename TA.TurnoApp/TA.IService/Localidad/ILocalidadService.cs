using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Localidad.Dto;

namespace TA.IService.Localidad
{
    public interface ILocalidadService
    {
        LocalidadDto Add(LocalidadDto dto);

        LocalidadDto Update(LocalidadDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<LocalidadDto> GetAll();

        IEnumerable<LocalidadDto> GetAllFilter(string query);

        LocalidadDto GetById(long id);
    }
}
