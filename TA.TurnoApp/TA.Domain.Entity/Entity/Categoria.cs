using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TA.Domain.BaseEntity;

namespace TA.Domain.Entity.Entity
{
    [Table("Categoria")]
    public class Categoria : BaseEntity.BaseEntity
    {
        public string Descripcion { get; set; }

        public bool EstaEliminado { get; set; }

        //************************************************//

        public virtual ICollection<Turno> Turnos { get; set; }
    }
}
