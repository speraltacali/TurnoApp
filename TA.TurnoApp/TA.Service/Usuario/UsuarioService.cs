using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.Usuario;
using TA.Infraestructure.Repository.Usuario;
using TA.IService.Usuario;
using TA.IService.Usuario.Dto;

namespace TA.Service.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository = new UsuarioRepository();

        public UsuarioDto Add(UsuarioDto dto)
        {
            var obj = new Domain.Entity.Entity.Usuario()
            {
                User = dto.User ,
                Password = dto.Password ,
                Bloqueado = dto.Bloqueado ,
                PerfilId = dto.PerfilId,
                Eliminado = dto.Eliminado
            };

            _usuarioRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public UsuarioDto Update(UsuarioDto dto)
        {
            var obj = _usuarioRepository.GetById(dto.Id);

            if(obj != null)
            {
                obj.User = dto.User;
                obj.Password = dto.Password;
                obj.Bloqueado = dto.Bloqueado;
                obj.PerfilId = dto.PerfilId;

                _usuarioRepository.Update(obj);
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
            var obj = _usuarioRepository.GetById(id);

            if (obj != null)
            {
                obj.Eliminado = true;

                _usuarioRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<UsuarioDto> GetAll()
        {
            return _usuarioRepository.GetAll()
                .Select(x => new UsuarioDto()
                {
                    Id = x.Id,
                    User = x.User,
                    Password = x.Password,
                    Bloqueado = x.Bloqueado,
                    Eliminado = x.Eliminado,
                    PerfilId = x.PerfilId
                }).ToList();
        }

        public IEnumerable<UsuarioDto> GetByFilter(string query)
        {
            return _usuarioRepository.GetByFilter(x=>x.User.Contains(query)
                        && x.Eliminado != true)
                .Select(x => new UsuarioDto()
                {
                    Id = x.Id,
                    User = x.User,
                    Password = x.Password,
                    Bloqueado = x.Bloqueado,
                    Eliminado = x.Eliminado,
                    PerfilId = x.PerfilId
                }).ToList();
        }

        public UsuarioDto GetById(long id)
        {
            var obj = _usuarioRepository.GetById(id);

            if (obj != null)
            {
                return new UsuarioDto()
                {
                    Id = obj.Id,
                    User = obj.User,
                    Password = obj.Password,
                    Bloqueado = obj.Bloqueado,
                    PerfilId = obj.PerfilId,
                    Eliminado = obj.Eliminado
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _usuarioRepository.Save();
        }

    }
}
