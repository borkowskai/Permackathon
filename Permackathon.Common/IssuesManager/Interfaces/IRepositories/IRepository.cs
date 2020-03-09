using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.Interfaces.IRepositories
{
    public interface IRepository<T, TKey>
       //where TKey : struct
       // where struct Doit être de type valeur
       //where T : IEntity<TKey>, new()
       where T :class
    {
        IEnumerable<T> GetAll();
        T GetById(TKey id);
        T Insert(T toInsert);
        bool Update(T toUpdate);
        bool Delete(TKey id);
        bool SoftDelete(TKey id);
    }


}
