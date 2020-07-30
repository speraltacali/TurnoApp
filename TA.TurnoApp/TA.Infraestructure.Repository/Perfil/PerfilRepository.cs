using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Perfil;
using TA.Repository;

namespace TA.Infraestructure.Repository.Perfil
{
    public class PerfilRepository : Repository<Domain.Entity.Entity.Perfil> , IPerfilRepository
    {
    }
}
