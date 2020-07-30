using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Pais")]
    public class Pais : BaseEntity.BaseEntity
    {
        public string Descripcion { get; set; }

        public bool Eliminado { get; set; }

        //********************************************//

        public virtual ICollection<Provincia> Provincias { get; set; }
    }
}
