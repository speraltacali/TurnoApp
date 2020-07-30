using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Table")]
    public class Localidad : BaseEntity.BaseEntity
    {
        public string Descripcion { get; set; }

        public bool Eliminado { get; set; }

        [ForeignKey("Provincia")]
        public long ProvinciaId { get; set; }

        //*****************************************************//

        public virtual Provincia Provincia { get; set; }

        public virtual ICollection<Domicilio> Domicilios { get; set; }
    }
}
