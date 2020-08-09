using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.User_Empresa;
using TA.Infraestructure.Repository.User_Empresa;
using TA.IService.User_Empresa;
using TA.IService.User_Empresa.Dto;

namespace TA.Service.User_Empresa
{
    public class User_EmpresaService : IUser_EmpresaService
    {

        private readonly IUser_EmpresaRepository _user_EmpresaRepository = new User_EmpresaRepository();

        public User_EmpresaDto Add(User_EmpresaDto dto)
        {
            var obj = new Domain.Entity.Entity.User_Empresa()
            {
                EmpresaId = dto.EmpresaId,
                UsuarioId = dto.UsuarioId
            };

            _user_EmpresaRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public User_EmpresaDto Update(User_EmpresaDto dto)
        {
            var obj = _user_EmpresaRepository.GetById(dto.Id);

            if(obj != null)
            {
                obj.EmpresaId = dto.EmpresaId;
                obj.UsuarioId = dto.UsuarioId;

                _user_EmpresaRepository.Update(obj);
                Save();

                return dto;
            }
            else
            {
                return null;
            }
        }

        public void Delete(long id)
        {
            var obj = _user_EmpresaRepository.GetById(id);

            if (obj != null)
            {
                _user_EmpresaRepository.Delete(obj);
                Save();
            }
        }

        public IEnumerable<User_EmpresaDto> GetAll()
        {
            return _user_EmpresaRepository.GetAll()
                .Select(x => new User_EmpresaDto()
                {
                    Id = x.Id,
                    EmpresaId = x.EmpresaId,
                    UsuarioId = x.UsuarioId
                }).ToList();
        }


        public User_EmpresaDto GetById(long id)
        {
            var obj = _user_EmpresaRepository.GetById(id);

            if (obj != null)
            {
                return new User_EmpresaDto()
                {
                    Id = obj.Id,
                    EmpresaId = obj.EmpresaId,
                    UsuarioId = obj.UsuarioId
                };
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<User_EmpresaDto> GetByEmpresa(long id)
        {
            return _user_EmpresaRepository.GetByFilter(X=> X.EmpresaId == id)
                .Select(x => new User_EmpresaDto()
                {
                    Id = x.Id,
                    EmpresaId = x.EmpresaId,
                    UsuarioId = x.UsuarioId
                }).ToList();
        }

        public IEnumerable<User_EmpresaDto> GetByUsuario(long id)
        {
            return _user_EmpresaRepository.GetByFilter(X=>X.UsuarioId == id)
                .Select(x => new User_EmpresaDto()
                {
                    Id = x.Id,
                    EmpresaId = x.EmpresaId,
                    UsuarioId = x.UsuarioId
                }).ToList();
        }

        public void Save()
        {
            _user_EmpresaRepository.Save();
        }
    }
}
