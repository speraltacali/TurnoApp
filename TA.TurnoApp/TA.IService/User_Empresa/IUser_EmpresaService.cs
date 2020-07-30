using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.User_Empresa.Dto;

namespace TA.IService.User_Empresa
{
    public interface IUser_EmpresaService
    {
        User_Empresa Add(User_EmpresaDto dto);

        User_Empresa Update(User_Empresa dto);

        void Delete(long id);

        void Save();

        IEnumerable<User_Empresa> GetAll();

        IEnumerable<User_Empresa> GetAllFilter(string query);

        User_Empresa GetById(long id);
    }
}
