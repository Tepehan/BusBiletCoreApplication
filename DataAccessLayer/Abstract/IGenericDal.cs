using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        //Çekirdek yapı
        void insert(T entity);
        void delete(T entity);
        void update(T entity);
        List<T> list();
        List<T> listBy(Expression<Func<T,bool>>filter);
        T get(Expression<Func<T, bool>> filter);
    }
}
