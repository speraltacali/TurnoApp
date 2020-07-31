using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Usuario.Dto;

namespace TA.IService.Usuario
{
    public interface IUsuarioService
    {
        UsuarioDto Add(UsuarioDto dto);

        UsuarioDto Update(UsuarioDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<UsuarioDto> GetAll();

        IEnumerable<UsuarioDto> GetByFilter(string query);

        UsuarioDto GetById(long id);
    }
}
