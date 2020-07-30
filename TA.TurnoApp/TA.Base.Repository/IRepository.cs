using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.BaseEntity;

namespace TA.Repository.Base
{
    public interface IRepository<T> : IRepositoryPercistence<T> , IRepositoryQuery<T> where T : BaseEntity
    {
    }
}
