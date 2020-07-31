using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Cliente.Dto;

namespace TA.IService.Cliente
{
    public interface IClienteService
    {
        ClienteDto Add(ClienteDto dto);

        ClienteDto Update(ClienteDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<ClienteDto> GetAll();

        IEnumerable<ClienteDto> GetByFilter(string query);

        ClienteDto GetById(long id);
    }
}
