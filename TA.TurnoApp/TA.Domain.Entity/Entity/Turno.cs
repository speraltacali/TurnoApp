using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Turno")]
    public class Turno : BaseEntity.BaseEntity
    {
        public DateTime FechaTurno { get; set; }

        public DateTime Dia { get; set; }

        public DateTime Hora { get; set; }

        public string Descripcion { get; set; }

        public bool Ocupado { get; set; }

        public bool CancelacionEmpresa { get; set; }

        [ForeignKey("Empresa")]
        public long EmpresaId { get; set; }

        [ForeignKey("Categoria")]
        public long CategoriaId { get; set; }

        //**************************************************************//

        public virtual Empresa Empresa { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Reserva_Turno> Reserva_Turnos { get; set; }
    }
}
