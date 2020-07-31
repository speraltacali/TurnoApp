using System;
using System.Collections.Generic;
using System.Text;
using TA.IService.Turno.Dto;

namespace TA.IService.Turno
{
    public interface ITurnoService
    {
        TurnoDto Add(TurnoDto dto);

        TurnoDto Update(TurnoDto dto);

        void Delete(long id);

        void Save();

        IEnumerable<TurnoDto> GetAll();

        IEnumerable<TurnoDto> GetByFilter(string query);

        TurnoDto GetById(long id);
    }
}
