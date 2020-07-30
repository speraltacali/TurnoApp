using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TA.Domain.BaseEntity;
using TA.Infraestructure.Context;
using TA.Repository.Base;

namespace TA.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected Context Context;

        public Repository()
            : this(new Context())
        {

        }

        public Repository(Context context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            var Entity = GetById(entity.Id);
            Context.Set<T>().Remove(Entity);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            Context.Set<T>().Attach(entity);
            Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        }

        //***************************************************************************************//

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().AsNoTracking().ToList();
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> query = Context.Set<T>().AsNoTracking();

            query = includeProperty.Aggregate(query, (current, IncludeProperties) => current.Include(IncludeProperties));

            return query.ToList();
        }

        public IEnumerable<T> GetAll(string includeProperty)
        {
            IQueryable<T> query = Context.Set<T>().AsNoTracking();

            query = includeProperty.Split('.').Aggregate(query, (current, includeProperties) => current.Include(includeProperties));

            return query.ToList();
        }

        //***************************************************************************************//

        public IEnumerable<T> GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().AsNoTracking().Where(predicate).ToList();
        }

        public IEnumerable<T> GetByFilter(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> query = Context.Set<T>().AsNoTracking();

            query = includeProperty.Aggregate(query, (current, includeProperties) => current.Include(includeProperties));

            return query.ToList();
        }

        public IEnumerable<T> GetByFilter(Expression<Func<T, bool>> predicate, string includeProperty)
        {
            IQueryable<T> query = Context.Set<T>().AsNoTracking();

            query = includeProperty.Split('.').Aggregate(query, (current, includePorperties) => current.Include(includePorperties));

            return query.ToList();
        }

        //***************************************************************************************//

        public T GetById(long id)
        {
            return Context.Set<T>().Find(id);
        }

        public T GetById(long id, params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> query = Context.Set<T>().AsNoTracking();

            query = includeProperty.Aggregate(query, (current, includeProperties) => current.Include(includeProperties));

            return query.FirstOrDefault(x=>x.Id == id);
        }

        public T GetById(long id, string includeProperty)
        {
            IQueryable<T> query = Context.Set<T>().AsNoTracking();

            query = includeProperty.Split('.').Aggregate(query, (current, includeProperties) => current.Include(includeProperty));

            return query.FirstOrDefault(x => x.Id == id);
        }
    }
}
