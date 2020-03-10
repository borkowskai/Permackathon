using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Common.AccessHelpers
{
    public interface IRepository<TType, TIdType>
        where TType : class
    {
        bool Remove(TType entity);
        bool Remove(TIdType Id);
        IEnumerable<TType> GetAll();
        TType GetById(TIdType Id);
        TType Add(TType Entity);
        TType Update(TType Entity);
    }
}
