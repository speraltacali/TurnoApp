using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Reserva_Turno.Dto;

namespace TA.IService.Reserva_Turno
{
    public interface IReserva_TurnoService
    {
        Reserva_TurnoDto Add(Reserva_TurnoDto dto);

        Reserva_TurnoDto Update(Reserva_TurnoDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<Reserva_TurnoDto> GetAll();

        IEnumerable<Reserva_TurnoDto> GetByTurno(long id);

        IEnumerable<Reserva_TurnoDto> GetByCliente(long id);

        Reserva_TurnoDto GetById(long id);
    }
}
