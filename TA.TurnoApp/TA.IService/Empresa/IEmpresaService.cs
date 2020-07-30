using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Empresa.Dto;

namespace TA.IService.Empresa
{
    public interface IEmpresaService
    {
        EmpresaDto Add(EmpresaDto dto);

        EmpresaDto Update(EmpresaDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<EmpresaDto> GetAll();

        IEnumerable<EmpresaDto> GetAllFilter(string query);

        EmpresaDto GetById(long id);
    }
}
