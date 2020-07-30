using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.User_Empresa.Dto
{
    public class User_EmpresaDto : BaseEntityDto
    {
        public long EmpresaId { get; set; }

        public long UsuarioId { get; set; }
    }
}
