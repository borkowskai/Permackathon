using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.Interfaces.IRepositories
{
    public interface IRepository<T, TKey>
       where TKey : struct
       where T : IEntity<TKey>, new()
    {
        IEnumerable<T> GetAll();
        T GetById(TKey id);
        T Insert(T toInsert);
        bool Update(T toUpdate);
        bool Delete(TKey id);
        bool SoftDelete(TKey id);

    }

}
