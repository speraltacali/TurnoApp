using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Reserva_Turno")]
    public class Reserva_Turno : BaseEntity.BaseEntity
    {
        [ForeignKey("Turno")]
        public long TurnoId { get; set; }

        public long ClienteId { get; set; }

        public DateTime FechaReserva { get; set; }

        public bool Confirmacion { get; set; }

        public bool CancelacionTurno { get; set; }

        //*******************************************************//

        public virtual Turno Turno { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
