using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.User_Empresa;
using TA.Repository;

namespace TA.Infraestructure.Repository.User_Empresa
{
    public class User_EmpresaRepository : Repository<Domain.Entity.Entity.User_Empresa> , IUser_EmpresaRepository
    {
    }
}
