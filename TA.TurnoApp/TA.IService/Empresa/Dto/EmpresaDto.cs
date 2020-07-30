using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Empresa.Dto
{
    public class EmpresaDto : BaseEntityDto
    {
        public string Cuit { get; set; }

        public string Descripcion { get; set; }

        public DateTime InicioActividad { get; set; }

        public string Mail { get; set; }

        public bool Eliminado { get; set; }

        public string Telefono { get; set; }

        public byte[] Imagen { get; set; }

    }
}
