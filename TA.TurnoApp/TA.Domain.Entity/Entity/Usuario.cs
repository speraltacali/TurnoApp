using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Usuario")]
    public class Usuario : BaseEntity.BaseEntity
    {
        public string User { get; set; }

        public string Password { get; set; }

        public bool Bloqueado { get; set; }

        [ForeignKey("Perfil")]
        public long PerfilId { get; set; }

        //********************************************//

        public virtual Perfil Perfil { get; set; }

        public virtual ICollection<User_Cliente> User_Clientes { get; set; }

        public virtual ICollection<User_Empresa> User_Empresas { get; set; }
    }
}
