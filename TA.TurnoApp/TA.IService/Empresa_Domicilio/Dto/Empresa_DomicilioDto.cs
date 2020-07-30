using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Empresa_Domicilio.Dto
{
    public class Empresa_DomicilioDto : BaseEntityDto
    {
        public long EmpresaId { get; set; }

        public long DomicilioId { get; set; }
    }
}
