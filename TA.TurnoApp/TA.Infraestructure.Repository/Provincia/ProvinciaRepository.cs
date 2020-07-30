using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Provincia;
using TA.Repository;

namespace TA.Infraestructure.Repository.Provincia
{
    public class ProvinciaRepository : Repository<Domain.Entity.Entity.Provincia> , IProvinciaRepository
    {
    }
}
