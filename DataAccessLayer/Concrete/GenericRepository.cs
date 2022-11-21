using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T:class
    {
        Context context = new Context();
        DbSet<T> _objects;
        public GenericRepository() {
            _objects= context.Set<T>();
        }
        public void delete(T entity)
        {
            _objects.Remove(entity);
        }

        public T get(Expression<Func<T, bool>> filter)
        {
            return _objects.Where(filter).SingleOrDefault();
        }

        public void insert(T entity)
        {
            _objects.Add(entity);
        }

        public List<T> list()
        {
            return _objects.ToList();
        }

        public List<T> listBy(Expression<Func<T, bool>> filter)
        {
            return _objects.Where(filter).ToList();
        }

        public void update(T entity)
        {
            _objects.Update(entity);
        }
    }
}
