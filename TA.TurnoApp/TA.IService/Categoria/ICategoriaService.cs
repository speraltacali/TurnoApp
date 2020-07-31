using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Categoria.Dto;

namespace TA.IService.Categoria
{
    public interface ICategoriaService
    {
        CategoriaDto Add(CategoriaDto dto);

        CategoriaDto Update(CategoriaDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<CategoriaDto> GetAll();

        IEnumerable<CategoriaDto> GetByFilter(string query);

        CategoriaDto GetById(long id);

    }
}
