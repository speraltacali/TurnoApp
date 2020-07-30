using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Turno;
using TA.Repository;

namespace TA.Infraestructure.Repository.Turno
{
    public class TurnoRepository : Repository<Domain.Entity.Entity.Turno> , ITurnoRepository
    {
    }
}
