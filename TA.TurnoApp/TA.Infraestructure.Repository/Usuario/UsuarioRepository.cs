using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Usuario;
using TA.Repository;

namespace TA.Infraestructure.Repository.Usuario
{
    public class UsuarioRepository : Repository<Domain.Entity.Entity.Usuario> , IUsuarioRepository 
    {
    }
}
