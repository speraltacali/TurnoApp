using System;
using System.Collections.Generic;
using System.Text;
using TA.Domain.BaseEntity;

namespace TA.Repository.Base
{
    public interface IRepositoryPercistence<T> where T : BaseEntity
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Save();
    }
}
