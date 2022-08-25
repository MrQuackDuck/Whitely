using System.Collections.Generic;

namespace Whitely.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(T entity);
        bool Delete(T entity);

        T Get(int id);
        List<T> Select();
    }
}