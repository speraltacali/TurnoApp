using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Domicilio.Dto
{
    public class DomicilioDto : BaseEntityDto
    {
        public string Calle { get; set; }

        public string Numero { get; set; }

        public string Manzana { get; set; }

        public string Piso { get; set; }

        public int NumDepartamento { get; set; }

        public bool Eliminado { get; set; }

        public long LocalidadId { get; set; }
    }
}
