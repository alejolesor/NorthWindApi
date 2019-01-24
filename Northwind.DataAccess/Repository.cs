using Northwind.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList()
        {
            throw new NotImplementedException();
        }

        public int insert(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
