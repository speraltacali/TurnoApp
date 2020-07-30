using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Domicilio;
using TA.Repository;

namespace TA.Infraestructure.Repository.Domicilio
{
    public class DomicilioRepository : Repository<Domain.Entity.Entity.Domicilio> , IDomicilioRepository
    {
    }
}
