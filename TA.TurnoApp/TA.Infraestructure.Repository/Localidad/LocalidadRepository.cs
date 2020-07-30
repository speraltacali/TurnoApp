using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Localidad;
using TA.Repository;

namespace TA.Infraestructure.Repository.Localidad
{
    public class LocalidadRepository : Repository<Domain.Entity.Entity.Localidad> , ILocalidadRepository
    {
    }
}
