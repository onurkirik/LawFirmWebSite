using MyWebSite.Core.Entities;
using MyWebSite.DATA.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.DATA.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
