using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Provincia.Dto
{
    public class ProvinciaDto : BaseEntityDto
    {
        public string Descripcion { get; set; }

        public bool Eliminado { get; set; }

        public long PaisId { get; set; }
    }
}
