using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Core.Interfaces.Repositories
{
    public interface IBaseRepository
    {
        IEnumerable<TEntity> All<TEntity>() where TEntity : class;
    }
}
