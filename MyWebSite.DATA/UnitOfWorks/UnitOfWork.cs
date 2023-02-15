using MyWebSite.DATA.Context;
using MyWebSite.DATA.Repositories.Abstractions;
using MyWebSite.DATA.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DATA.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }
        public async ValueTask DisposeAsync()
        {
            await _db.DisposeAsync();
        }

        public int Save()
        {
            return _db.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _db.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(_db);
        }
    }
}
