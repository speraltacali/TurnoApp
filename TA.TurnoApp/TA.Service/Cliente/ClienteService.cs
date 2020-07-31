using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TA.Domain.Repository.Cliente;
using TA.Infraestructure.Repository.Cliente;
using TA.IService.Cliente;
using TA.IService.Cliente.Dto;

namespace TA.Service.Cliente
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository = new ClienteRepository();
        public ClienteDto Add(ClienteDto dto)
        {
            var obj = new Domain.Entity.Entity.Cliente
            {
                Apellido = dto.Apellido,
                Nombre = dto.Nombre,
                Dni = dto.Dni,
                Mail = dto.Mail,
                Eliminado = dto.Eliminado,
                Telefono = dto.Telefono,
                Imagen = dto.Imagen,
                DomicilioId = dto.DomicilioId
            };

            _clienteRepository.Add(obj);
            Save();

            dto.Id = obj.Id;
            return dto;
        }

        public ClienteDto Update(ClienteDto dto)
        {
            var obj = _clienteRepository.GetById(dto.Id);

            if (obj != null)
            {
                obj.Apellido = dto.Apellido;
                obj.Nombre = dto.Nombre;
                obj.Dni = dto.Dni;
                obj.Mail = dto.Mail;
                obj.Telefono = dto.Telefono;
                obj.Imagen = dto.Imagen;
                obj.DomicilioId = dto.DomicilioId;

                _clienteRepository.Update(obj);
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
            var obj = _clienteRepository.GetById(id);

            if(obj != null)
            {
                obj.Eliminado = true;

                _clienteRepository.Update(obj);
                Save();
            }
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            return _clienteRepository.GetAll()
                .Select(x => new ClienteDto
                {
                    Id = x.Id,
                    Apellido = x.Apellido,
                    Nombre = x.Nombre,
                    Dni = x.Dni,
                    Mail = x.Mail,
                    Telefono = x.Telefono,
                    Imagen = x.Imagen,
                    DomicilioId = x.DomicilioId
                }).ToList();
        }

        public IEnumerable<ClienteDto> GetByFilter(string query)
        {
            return _clienteRepository.GetByFilter(x => x.Apellido.Contains(query)
                            || x.Nombre.Contains(query)
                            || x.Dni.Contains(query) && !x.Eliminado)
                .Select(x => new ClienteDto
                {
                    Id = x.Id,
                    Apellido = x.Apellido,
                    Nombre = x.Nombre,
                    Dni = x.Dni,
                    Mail = x.Mail,
                    Telefono = x.Telefono,
                    Imagen = x.Imagen,
                    DomicilioId = x.DomicilioId
                }).ToList();
        }

        public ClienteDto GetById(long id)
        {
            var obj = _clienteRepository.GetById(id);

            if (obj != null)
            {
                return new ClienteDto()
                {
                    Id = obj.Id,
                    Apellido = obj.Apellido,
                    Nombre = obj.Nombre,
                    Dni = obj.Dni,
                    Mail = obj.Mail,
                    Telefono = obj.Telefono,
                    Imagen = obj.Imagen,
                    DomicilioId = obj.DomicilioId
                };
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            _clienteRepository.Save();
        }


    }
}
