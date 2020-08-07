using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Turno.Dto
{
    public class TurnoDto : BaseEntityDto
    {
        public DateTime FechaTurno { get; set; }

        public DateTime Dia { get; set; }

        public DateTime Hora { get; set; }

        public string Descripcion { get; set; }

        public bool Ocupado { get; set; }

        public bool CancelacionEmpresa { get; set; }

        public bool Eliminado { get; set; }

        public long EmpresaId { get; set; }

        public long CategoriaId { get; set; }
    }
}
