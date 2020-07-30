using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Provincia")]
    public class Provincia : BaseEntity.BaseEntity
    {
        public string Descripcion { get; set; }

        public bool Eliminado { get; set; }

        [ForeignKey("Pais")]
        public long PaisId { get; set; }

        //***********************************************//

        public virtual Pais Pais { get; set; }

        public virtual ICollection<Localidad> Localidades { get; set; }
    }
}
