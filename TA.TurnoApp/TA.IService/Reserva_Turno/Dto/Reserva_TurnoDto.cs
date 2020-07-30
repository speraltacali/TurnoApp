using System;
using System.Collections.Generic;
using System.Text;
using TA.Service.Base;

namespace TA.IService.Reserva_Turno.Dto
{
    public class Reserva_TurnoDto : BaseEntityDto
    {
        public long TurnoId { get; set; }

        public long ClienteId { get; set; }

        public DateTime FechaReserva { get; set; }

        public bool Confirmacion { get; set; }

        public bool CancelacionTurno { get; set; }
    }
}
