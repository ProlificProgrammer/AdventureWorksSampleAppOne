using AdventureWorks.Core.Interfaces.Repositories;
using AdventureWorks.Core.Model.HumanResources;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Infrastructure.Data.Repositories
{
    public class HumanResourcesRepository : BaseRepository, IHumanResourcesRepository
    {
        HumanResourcesDbContext _dbContext;

        public HumanResourcesRepository(HumanResourcesDbContext context) : base(context)
        {
            _dbContext = context;
            _dbContext.Set<Department>().ToList();
        }

        
        public Department GetTestDepartment()
        {
            var t = _dbContext.Department.FirstOrDefault();
            return t;
        }
    }
}
