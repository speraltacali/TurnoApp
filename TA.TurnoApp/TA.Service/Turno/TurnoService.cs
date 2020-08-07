using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.Turno;
using TA.Infraestructure.Repository.Turno;
using TA.IService.Turno;
using TA.IService.Turno.Dto;

namespace TA.Service.Turno
{
    public class TurnoService : ITurnoService
    {
        private readonly ITurnoRepository _turnoRepository = new TurnoRepository();

        public TurnoDto Add(TurnoDto dto)
        {
            var obj = new Domain.Entity.Entity.Turno()
            {
                FechaTurno = dto.FechaTurno,
                Dia = dto.Dia,
                Hora = dto.Hora,
                Descripcion = dto.Descripcion,
                Ocupado = dto.Ocupado,
                CancelacionEmpresa = dto.CancelacionEmpresa,
                EmpresaId = dto.EmpresaId,
                Eliminado = dto.Eliminado,
                CategoriaId = dto.CategoriaId
            };

            _turnoRepository.Add(obj);
            Save();

            dto.Id = obj.Id;

            return dto;
        }

        public TurnoDto Update(TurnoDto dto)
        {
            var obj = _turnoRepository.GetById(dto.Id);

            if (obj != null)
            {
                obj.FechaTurno = dto.FechaTurno;
                obj.Dia = dto.Dia;
                obj.Hora = dto.Hora;
                obj.Descripcion = dto.Descripcion;
                obj.Ocupado = dto.Ocupado;
                obj.CancelacionEmpresa = dto.CancelacionEmpresa;
                obj.EmpresaId = dto.EmpresaId;
                obj.CategoriaId = dto.CategoriaId;

                _turnoRepository.Update(obj);
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
            var obj = _turnoRepository.GetById(id);

            if(obj != null)
            {
                obj.Eliminado = true;

                _turnoRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<TurnoDto> GetAll()
        {
            return _turnoRepository.GetAll()
                .Select(x => new TurnoDto()
                {
                    Id = x.Id,
                    FechaTurno = x.FechaTurno,
                    Dia = x.Dia,
                    Hora = x.Hora,
                    Descripcion = x.Descripcion,
                    Ocupado = x.Ocupado,
                    CancelacionEmpresa = x.CancelacionEmpresa,
                    Eliminado = x.Eliminado,
                    EmpresaId = x.EmpresaId,
                    CategoriaId = x.CategoriaId
                }).ToList();
        }

        public IEnumerable<TurnoDto> GetByFilter(string query)
        {
            return _turnoRepository.GetByFilter(x=>x.Descripcion.Contains(query)
                    && x.Eliminado != true)
                .Select(x => new TurnoDto()
                {
                    Id = x.Id,
                    FechaTurno = x.FechaTurno,
                    Dia = x.Dia,
                    Hora = x.Hora,
                    Descripcion = x.Descripcion,
                    Ocupado = x.Ocupado,
                    CancelacionEmpresa = x.CancelacionEmpresa,
                    Eliminado = x.Eliminado,
                    EmpresaId = x.EmpresaId,
                    CategoriaId = x.CategoriaId
                }).ToList();
        }

        public TurnoDto GetById(long id)
        {
            var obj = _turnoRepository.GetById(id);

            if (obj != null)
            {
                return new TurnoDto()
                {
                    FechaTurno = obj.FechaTurno,
                    Dia = obj.Dia,
                    Hora = obj.Hora,
                    Descripcion = obj.Descripcion,
                    Ocupado = obj.Ocupado,
                    CancelacionEmpresa = obj.CancelacionEmpresa,
                    EmpresaId = obj.EmpresaId,
                    Eliminado = obj.Eliminado,
                    CategoriaId = obj.CategoriaId
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _turnoRepository.Save();
        }

    }
}
