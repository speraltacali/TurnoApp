using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Reserva_Turno;
using TA.Repository;

namespace TA.Infraestructure.Repository.Reserva_Turno
{
    public class Reserva_TurnoRepository : Repository<Domain.Entity.Entity.Reserva_Turno> , IReserva_TurnoRepository
    {
    }
}
