using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Read();
        bool Add(T obj);
        bool Delete(T obj);
        bool Update(T obj);
        T GetById(int id);
    }
}
