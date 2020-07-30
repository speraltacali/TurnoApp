using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Usuario.Dto
{
    public class UsuarioDto : BaseEntityDto
    {
        public string User { get; set; }

        public string Password { get; set; }

        public bool Bloqueado { get; set; }

        public long PerfilId { get; set; }
    }
}
