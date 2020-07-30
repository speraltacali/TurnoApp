using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Pais.Dto
{
    public class PaisDto : BaseEntityDto
    {
        public string Descripcion { get; set; }

        public bool Eliminado { get; set; }
    }
}
