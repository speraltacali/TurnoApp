using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Perfil.Dto;

namespace TA.IService.Perfil
{
    public interface IPerfilService
    {
        PerfilDto Add(PerfilDto dto);

        PerfilDto Update(PerfilDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<PerfilDto> GetAll();

        IEnumerable<PerfilDto> GetByFilter(string query);

        PerfilDto GetById(long id);
    }
}
