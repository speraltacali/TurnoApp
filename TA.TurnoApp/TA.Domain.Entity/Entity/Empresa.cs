using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Empresa")]
    public class Empresa : BaseEntity.BaseEntity
    {
        public string Cuit { get; set; }

        public string Descripcion { get; set; }

        public DateTime InicioActividad { get; set; }

        public string Mail { get; set; }

        public bool Eliminado { get; set; }

        public string Telefono { get; set; }

        public byte[] Imagen { get; set; }


        //****************************************************//

        public virtual ICollection<Empresa_Domicilio> Empresa_Domicilios { get; set; }

        public virtual ICollection<Turno> Turnos { get; set; }
    }
}
