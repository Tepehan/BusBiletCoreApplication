using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void insert(T entity);
        void delete(T entity);
        void update(T entity);
        List<T> list();
    }
}
