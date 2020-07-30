using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.User_Cliente;
using TA.Repository;

namespace TA.Infraestructure.Repository.User_Cliente
{
    public class User_ClienteRepository : Repository<Domain.Entity.Entity.User_Cliente> , IUser_ClienteRepository
    {
    }
}
