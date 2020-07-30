using TA.Domain.Repository.Empresa;
using TA.Repository;

namespace TA.Infraestructure.Repository.Empresa
{
    public class EmpresaRepository : Repository<Domain.Entity.Entity.Empresa> , IEmpresaRepository
    {
    }
}
