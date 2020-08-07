using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.Reserva_Turno;
using TA.Infraestructure.Repository.Reserva_Turno;
using TA.IService.Reserva_Turno;
using TA.IService.Reserva_Turno.Dto;

namespace TA.Service.Reserva_Turno
{
    public class Reserva_TurnoService : IReserva_TurnoService
    {
        private readonly IReserva_TurnoRepository _reserva_TurnoRepository = new Reserva_TurnoRepository();

        public Reserva_TurnoDto Add(Reserva_TurnoDto dto)
        {
            var obj = new Domain.Entity.Entity.Reserva_Turno()
            {
                TurnoId = dto.TurnoId,
                ClienteId = dto.ClienteId,
                FechaReserva = dto.FechaReserva,
                Confirmacion = dto.Confirmacion,
                CancelacionTurno = dto.CancelacionTurno
            };

            _reserva_TurnoRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public Reserva_TurnoDto Update(Reserva_TurnoDto dto)
        {
            var obj = _reserva_TurnoRepository.GetById(dto.Id);

            if(obj != null)
            {
                obj.TurnoId = dto.TurnoId;
                obj.ClienteId = dto.ClienteId;
                obj.FechaReserva = dto.FechaReserva;
                obj.Confirmacion = dto.Confirmacion;
                obj.CancelacionTurno = dto.CancelacionTurno;

                _reserva_TurnoRepository.Update(obj);
                Save();

                return dto;
            }
            else
            {
                return null;
            }
        }

        public void Delete(long id)
        {
            var obj = _reserva_TurnoRepository.GetById(id);

            if (obj != null)
            {
                _reserva_TurnoRepository.Delete(obj);
                Save();
            }
        }

        public IEnumerable<Reserva_TurnoDto> GetAll()
        {
            return _reserva_TurnoRepository.GetAll()
                .Select(x => new Reserva_TurnoDto()
                {
                    Id = x.Id,
                    TurnoId = x.TurnoId,
                    ClienteId = x.ClienteId,
                    FechaReserva = x.FechaReserva,
                    Confirmacion = x.Confirmacion,
                    CancelacionTurno = x.CancelacionTurno
                }).ToList();
        }

        public Reserva_TurnoDto GetById(long id)
        {
            var obj = _reserva_TurnoRepository.GetById(id);

            if (obj != null)
            {
                return new Reserva_TurnoDto()
                {
                    Id = obj.Id,
                    TurnoId = obj.TurnoId,
                    ClienteId = obj.ClienteId,
                    FechaReserva = obj.FechaReserva,
                    Confirmacion = obj.Confirmacion,
                    CancelacionTurno = obj.CancelacionTurno
                };
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Reserva_TurnoDto> GetByTurno(long id)
        {
            return _reserva_TurnoRepository.GetByFilter(x=> x.TurnoId == id)
                .Select(x => new Reserva_TurnoDto()
                {
                    Id = x.Id,
                    TurnoId = x.TurnoId,
                    ClienteId = x.ClienteId,
                    FechaReserva = x.FechaReserva,
                    Confirmacion = x.Confirmacion,
                    CancelacionTurno = x.CancelacionTurno
                }).ToList();
        }

        public IEnumerable<Reserva_TurnoDto> GetByCliente(long id)
        {
            return _reserva_TurnoRepository.GetByFilter(x=> x.ClienteId == id)
                .Select(x => new Reserva_TurnoDto()
                {
                    Id = x.Id,
                    TurnoId = x.TurnoId,
                    ClienteId = x.ClienteId,
                    FechaReserva = x.FechaReserva,
                    Confirmacion = x.Confirmacion,
                    CancelacionTurno = x.CancelacionTurno
                }).ToList();
        }

        public void Save()
        {
            _reserva_TurnoRepository.Save();
        }
    }
}
