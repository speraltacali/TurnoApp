using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.User_Cliente.Dto
{
    public class User_ClienteDto : BaseEntityDto
    {
        public long ClienteId { get; set; }

        public long UsuarioId { get; set; }
    }
}
