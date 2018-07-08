using AdventureWorks.Core.Model.HumanResources;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Core.Interfaces.Repositories
{
    public interface IHumanResourcesRepository : IBaseRepository
    {
        Department GetTestDepartment();
    }
}
