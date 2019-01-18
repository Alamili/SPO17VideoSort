using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPO17VideoSort.Services
{
    public interface ISqlService
    {
        IQueryable<TEntity> Get<TEntity>() where TEntity : class;
        void Include<TEntity>(string[] entityNames) where TEntity : class;
    }
}
