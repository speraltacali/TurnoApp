using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.User_Empresa.Dto;

namespace TA.IService.User_Empresa
{
    public interface IUser_EmpresaService
    {
        User_EmpresaDto Add(User_EmpresaDto dto);

        User_EmpresaDto Update(User_EmpresaDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<User_EmpresaDto> GetAll();

        IEnumerable<User_EmpresaDto> GetByEmpresa(long id);

        IEnumerable<User_EmpresaDto> GetByUsuario(long id);

        User_EmpresaDto GetById(long id);
    }
}
