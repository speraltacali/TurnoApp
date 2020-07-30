using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Perfil")]
    public class Perfil : BaseEntity.BaseEntity
    {
        public string Descripcion { get; set; }
    }
}
