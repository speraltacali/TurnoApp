using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.Perfil;
using TA.Infraestructure.Repository.Perfil;
using TA.IService.Perfil;
using TA.IService.Perfil.Dto;

namespace TA.Service.Perfil
{
    public class PerfilService : IPerfilService
    {
        private readonly IPerfilRepository _perfilRepository = new PerfilRepository();

        public PerfilDto Add(PerfilDto dto)
        {
            var obj = new Domain.Entity.Entity.Perfil()
            {
                Descripcion = dto.Descripcion,
                Eliminado = dto.Eliminado
            };

            _perfilRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public PerfilDto Update(PerfilDto dto)
        {
            var obj = _perfilRepository.GetById(dto.Id);

            if(obj != null)
            {
                obj.Descripcion = dto.Descripcion;

                _perfilRepository.Update(obj);
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
            var obj = _perfilRepository.GetById(id);

            if (obj != null)
            {
                obj.Eliminado = true;

                _perfilRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<PerfilDto> GetAll()
        {
            return _perfilRepository.GetAll()
                .Select(x => new PerfilDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado
                }).ToList();
        }

        public IEnumerable<PerfilDto> GetByFilter(string query)
        {
            return _perfilRepository.GetByFilter(x=> x.Descripcion.Contains(query)
                        && x.Eliminado != true)
                .Select(x => new PerfilDto()
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.Eliminado
                }).ToList();
        }

        public PerfilDto GetById(long id)
        {
            var obj = _perfilRepository.GetById(id);

            if (obj != null)
            {
                return new PerfilDto()
                {
                    Id = obj.Id,
                    Descripcion  = obj.Descripcion,
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
            _perfilRepository.Save();
        }
    }
}
