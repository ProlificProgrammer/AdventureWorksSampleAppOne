using NUnit.Framework;
using System;

using System.Linq;
using AdventureWorks.Core.Interfaces.Repositories;
using AdventureWorks.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using AdventureWorks.Core.Model.HumanResources;
using AdventureWorks.Infrastructure.Data;

namespace AdventureWorks.Integration.Tests
{
    [TestFixture]
    public class SomeTests
    {

        [Test]
        public void Test()
        {
            using (var db = new HumanResourcesDbContext())
            {
                IHumanResourcesRepository rep = new HumanResourcesRepository(db);
                var dep = rep.GetTestDepartment();
                 var deps = new GenericRepository<Department>(db).All();
            }
        }

        [Test]
        public void TestForBaseRepo()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            //optionsBuilder.UseInternalServiceProvider
            optionsBuilder.UseSqlServer("Server=.\\sasiad;Database=AdventureWorks2014;Trusted_Connection=True;");
            using (var db = new HumanResourcesDbContext())
            {
                var rep = new HumanResourcesRepository(db);
                var aa = rep.All<Department>();
            }

        }

        [Test]
        public void TestForGenericRepo()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            //optionsBuilder.UseInternalServiceProvider
            optionsBuilder.UseSqlServer("Server=.\\sasiad;Database=AdventureWorks2014;Trusted_Connection=True;");

            using (var db = new HumanResourcesDbContext())
            {
                var deps = new GenericRepository<Department>(db).All();
               
            }

        }

        [Test]
        public void TestForGenericDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            //optionsBuilder.UseInternalServiceProvider
            optionsBuilder.UseSqlServer("Server=.\\sasiad;Database=AdventureWorks2014;Trusted_Connection=True;");

            using (var db = new GenericDbContext())
            {
                var deps = new GenericRepository<Department>(db).All();
            }
        }

    }
}
