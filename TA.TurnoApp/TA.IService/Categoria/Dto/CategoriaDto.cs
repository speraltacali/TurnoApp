using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Categoria.Dto
{
    public class CategoriaDto : BaseEntityDto
    {
        public string Descripcion { get; set; }

        public bool EstaEliminado { get; set; }
    }
}
