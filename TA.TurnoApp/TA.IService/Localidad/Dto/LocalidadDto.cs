using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Localidad.Dto
{
    public class LocalidadDto : BaseEntityDto
    {
        public string Descripcion { get; set; }

        public bool Eliminado { get; set; }

        public long ProvinciaId { get; set; }

    }
}
