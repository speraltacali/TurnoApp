using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("User_Cliente")]
    public class User_Cliente : BaseEntity.BaseEntity
    {
        [ForeignKey("Cliente")]
        public long ClienteId { get; set; }

        [ForeignKey("Usuario")]
        public long UsuarioId { get; set; }

        //*************************************************//

        public virtual Cliente Cliente { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
