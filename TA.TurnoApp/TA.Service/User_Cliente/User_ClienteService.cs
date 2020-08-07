using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.User_Cliente;
using TA.Infraestructure.Repository.User_Cliente;
using TA.IService.User_Cliente;
using TA.IService.User_Cliente.Dto;

namespace TA.Service.User_Cliente
{
    public class User_ClienteService : IUser_ClienteService
    {
        private readonly IUser_ClienteRepository _user_ClienteRepository = new User_ClienteRepository();

        public User_ClienteDto Add(User_ClienteDto dto)
        {
            var obj = new Domain.Entity.Entity.User_Cliente()
            {
                ClienteId = dto.ClienteId ,
                UsuarioId = dto.UsuarioId 
            };

            _user_ClienteRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public User_ClienteDto Update(User_ClienteDto dto)
        {
            var obj = _user_ClienteRepository.GetById(dto.Id);

            if(obj != null)
            {
                obj.ClienteId = dto.ClienteId;
                obj.UsuarioId = dto.UsuarioId;

                _user_ClienteRepository.Update(obj);
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
            var obj = _user_ClienteRepository.GetById(id);

            if (obj != null)
            {
                _user_ClienteRepository.Delete(obj);
                Save();
            }
        }

        public IEnumerable<User_ClienteDto> GetAll()
        {
            return _user_ClienteRepository.GetAll()
                .Select(x => new User_ClienteDto()
                {
                    Id = x.Id,
                    ClienteId = x.ClienteId,
                    UsuarioId = x.UsuarioId
                }).ToList();
        }

        public IEnumerable<User_ClienteDto> GetByUsuario(long id)
        {
            return _user_ClienteRepository.GetByFilter(x=>x.UsuarioId == id)
                .Select(x => new User_ClienteDto()
                {
                    Id = x.Id,
                    ClienteId = x.ClienteId,
                    UsuarioId = x.UsuarioId
                }).ToList();
        }

        public IEnumerable<User_ClienteDto> GetByCliente(long id)
        {
            return _user_ClienteRepository.GetByFilter(x=> x.ClienteId == id)
                .Select(x => new User_ClienteDto()
                {
                    Id = x.Id,
                    ClienteId = x.ClienteId,
                    UsuarioId = x.UsuarioId
                }).ToList();
        }

        public User_ClienteDto GetById(long id)
        {
            var obj = _user_ClienteRepository.GetById(id);

            if (obj != null)
            {
                return new User_ClienteDto()
                {
                    Id = obj.Id,
                    ClienteId = obj.ClienteId,
                    UsuarioId = obj.UsuarioId
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _user_ClienteRepository.Save();
        }
    }
}
