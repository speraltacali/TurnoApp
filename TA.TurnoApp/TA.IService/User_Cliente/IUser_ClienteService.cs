using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.User_Cliente.Dto;

namespace TA.IService.User_Cliente
{
    public interface IUser_ClienteService
    {
        User_ClienteDto Add(User_ClienteDto dto);

        User_ClienteDto Update(User_ClienteDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<User_ClienteDto> GetAll();

        IEnumerable<User_ClienteDto> GetByUsuario(long id);

        IEnumerable<User_ClienteDto> GetByCliente(long id);

        User_ClienteDto GetById(long id);
    }
}
