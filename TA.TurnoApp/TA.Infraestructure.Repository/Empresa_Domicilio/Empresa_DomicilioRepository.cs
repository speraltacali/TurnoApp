using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Empresa_Domicilio;
using TA.Repository;

namespace TA.Infraestructure.Repository.Empresa_Domicilio
{
    public class Empresa_DomicilioRepository : Repository<Domain.Entity.Entity.Empresa_Domicilio> , IEmpresa_DomicilioRepository 
    {
    }
}
