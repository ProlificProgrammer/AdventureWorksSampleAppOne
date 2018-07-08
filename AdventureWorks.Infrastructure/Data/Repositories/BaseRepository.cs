using AdventureWorks.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Infrastructure.Data.Repositories
{
    public abstract class BaseRepository : IBaseRepository
    {
         DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> All<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(_context).All();
           // return _context.Set<TEntity>().AsNoTracking().ToList();
        }
    }
}
