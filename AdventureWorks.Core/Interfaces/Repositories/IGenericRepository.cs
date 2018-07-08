using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Core.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> All();

    }
}
