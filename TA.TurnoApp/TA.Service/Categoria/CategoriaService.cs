using System;
using System.Collections.Generic;
using System.Linq;
using TA.Domain.Repository.Categoria;
using TA.Infraestructure.Repository.Categoria;
using TA.IService.Categoria;
using TA.IService.Categoria.Dto;

namespace TA.Service.Categoria
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository = new CategoriaRepository();

        public CategoriaDto Add(CategoriaDto dto)
        {
            var obj = new Domain.Entity.Entity.Categoria
            {
                Descripcion = dto.Descripcion,
                EstaEliminado = dto.EstaEliminado,
            };

            _categoriaRepository.Add(obj);
            Save();

            dto.Id = obj.Id;
            return dto;
        }

        public CategoriaDto Update(CategoriaDto dto)
        {
            var obj = _categoriaRepository.GetById(dto.Id);

            if (obj != null)
            {
                obj.Descripcion = dto.Descripcion;

                _categoriaRepository.Update(obj);
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
            var obj = _categoriaRepository.GetById(id);

            if(obj != null)
            {
                obj.EstaEliminado = true;

                _categoriaRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<CategoriaDto> GetAll()
        {
            return _categoriaRepository.GetAll()
                .Select(x => new CategoriaDto
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    EstaEliminado = x.EstaEliminado
                }).ToList();
        }

        public IEnumerable<CategoriaDto> GetByFilter(string query)
        {
            return _categoriaRepository.GetByFilter(x => x.Descripcion.Contains(query)
                        && !x.EstaEliminado)
                .Select(x => new CategoriaDto
                {
                    Id = x.Id,
                    Descripcion = x.Descripcion,
                    EstaEliminado = x.EstaEliminado
                }).ToList();
        }

        public CategoriaDto GetById(long id)
        {
            var obj = _categoriaRepository.GetById(id);

            if (obj != null)
            {
                return new CategoriaDto
                {
                    Id = obj.Id,
                    Descripcion = obj.Descripcion,
                    EstaEliminado = obj.EstaEliminado
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _categoriaRepository.Save();
        }


    }
}
