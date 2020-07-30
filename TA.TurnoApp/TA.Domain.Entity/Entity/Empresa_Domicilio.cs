using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TA.Domain.Entity.Entity
{
    [Table("Empresa_Domicilio")]
    public class Empresa_Domicilio : BaseEntity.BaseEntity
    {
        [ForeignKey("Empresa")]
        public long EmpresaId { get; set; }

        [ForeignKey("Domicilio")]
        public long DomicilioId { get; set; }

        //***********************************************//

        public virtual Empresa Empresa { get; set; }

        public virtual Domicilio Domicilio { get; set; }
    }
}
