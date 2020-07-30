using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Domicilio")]
    public class Domicilio : BaseEntity.BaseEntity
    {
        public string Calle { get; set; }

        public string Numero { get; set; }

        public string Manzana { get; set; }

        public string Piso { get; set; }

        public int NumDepartamento { get; set; }

        [ForeignKey("Localidad")]
        public long LocalidadId { get; set; }

        //******************************************************//

        public virtual ICollection<Empresa_Domicilio> Empresa_Domicilios { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }

        public virtual Localidad Localidad { get; set; } 

    }
}
