using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Cliente;
using TA.Repository;

namespace TA.Infraestructure.Repository.Cliente
{
    public class ClienteRepository : Repository<Domain.Entity.Entity.Cliente> , IClienteRepository
    {
    }
}
