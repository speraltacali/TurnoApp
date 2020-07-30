using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.Repository.Categoria;
using TA.Repository;

namespace TA.Infraestructure.Repository.Categoria
{
    public class CategoriaRepository : Repository<Domain.Entity.Entity.Categoria> , ICategoriaRepository
    {
    }
}
