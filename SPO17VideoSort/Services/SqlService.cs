using SPO17VideoSort.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SPO17VideoSort.Services
{
    public class SqlService : ISqlService
    {
        public VideoDbContext _db { get; set; }
        public SqlService(VideoDbContext db)
        {
            _db = db;
        }

        public IQueryable<TEntity> Get<TEntity>() where TEntity : class
        {
            return _db.Set<TEntity>();
        }

        public void Include<TEntity>(string[] entityNames) where TEntity : class
        {
            foreach (var name in entityNames)
                _db.Set<TEntity>().Include(name).Load();
        }
    }
}
