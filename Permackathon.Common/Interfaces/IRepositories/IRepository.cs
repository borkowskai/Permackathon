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

    //public interface IRepository<TType, TIdType>
    //    where TType : class
    //{
    //    //TODO ADD/MODIFY TEST TO RETURN TYPE BOOL FOR REMOVE
    //    bool Remove(TType entity);

    //    bool Remove(TIdType Id);

    //    //bool Remove(params TIdType[] entities);
    //    //bool Remove(IEnumerable<TIdType> entities);

    //    //CHANGETO IQuerable fait posible de faire un GetAll et l'affiner avec un Where et pas retourner toute la liste.
    //    IEnumerable<TType> GetAll();

    //    TType GetById(TIdType Id);

    //    TType Add(TType Entity);

    //    TType Update(TType Entity);
    //}
}
