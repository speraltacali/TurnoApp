using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Pais;
using TA.Repository;

namespace TA.Infraestructure.Repository.Pais
{
    public class PaisRepository : Repository<Domain.Entity.Entity.Pais> , IPaisRepository
    {
    }
}
