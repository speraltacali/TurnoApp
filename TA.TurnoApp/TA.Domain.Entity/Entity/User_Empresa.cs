using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("User_Empresa")]
    public class User_Empresa : BaseEntity.BaseEntity
    {
        [ForeignKey("Empresa")]
        public long EmpresaId { get; set; }

        [ForeignKey("Usuario")]
        public long UsuarioId { get; set; }

        //************************************************//

        public virtual Empresa Empresa { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
