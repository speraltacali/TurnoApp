using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Empresa;
using TA.Infraestructure.Repository.Empresa;
using TA.IService.Empresa;
using TA.IService.Empresa.Dto;

namespace TA.Service.Empresa
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _EmpresaRepository = new EmpresaRepository();

        public EmpresaDto Add(EmpresaDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmpresaDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmpresaDto> GetAllFilter(string query)
        {
            throw new NotImplementedException();
        }

        public EmpresaDto GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public EmpresaDto Update(EmpresaDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
