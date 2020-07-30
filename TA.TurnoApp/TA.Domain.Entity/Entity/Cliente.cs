using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Cliente")]
    public class Cliente : BaseEntity.BaseEntity
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Dni { get; set; }

        public string Mail { get; set; }

        public bool Eliminado { get; set; }

        public string Telefono { get; set; }

        public byte[] Imagen { get; set; }

        [ForeignKey("Domicilio")]
        public long DomicilioId { get; set; }

        //****************************************************//

        public virtual Domicilio Domicilio { get; set; }

        public virtual ICollection<User_Cliente> User_Clientes { get; set; }

        public virtual ICollection<Reserva_Turno> Reserva_Turnos { get; set; }
    }
}
