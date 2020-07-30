using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Cliente.Dto
{
    public class ClienteDto : BaseEntityDto
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Dni { get; set; }

        public string Mail { get; set; }

        public bool Eliminado { get; set; }

        public string Telefono { get; set; }

        public byte[] Imagen { get; set; }

        public long DomicilioId { get; set; }

    }
}
