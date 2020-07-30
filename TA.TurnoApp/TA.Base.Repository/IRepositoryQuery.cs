using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TA.Domain.BaseEntity;

namespace TA.Repository.Base
{
    public interface IRepositoryQuery<T> where T : BaseEntity
    {
        T GetById(long id);

        T GetById(long id, params Expression<Func<T, object>>[] includeProperty);

        T GetById(long id, string includeProperty);

        //******************************************************************************//

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(params Expression<Func<T,object>>[] includeProperty);

        IEnumerable<T> GetAll(string includeProperty);

        //******************************************************************************//

        IEnumerable<T> GetByFilter(Expression<Func<T , bool>> predicate);

        IEnumerable<T> GetByFilter(Expression<Func<T , bool >> predicate
            , params Expression<Func<T , object>>[] includeProperty);

        IEnumerable<T> GetByFilter(Expression<Func<T , bool>> predicate, string includeProperty);
    }
}
