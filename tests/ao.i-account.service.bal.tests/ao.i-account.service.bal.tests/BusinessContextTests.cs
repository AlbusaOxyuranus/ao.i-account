using System;
using System.Collections.Generic;
using ao.i_account.service.dal;
using ao.i_account.service.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ao.i_account.service.bal.tests
{
    [TestClass]
    public class BusinessContextTests //: FunctionalTest
    {
        [TestMethod]
        public void BusinessContext_IsClass_Test()
        {
            Assert.IsTrue(typeof(BusinessContext).IsClass);
        }

        [TestMethod]
        public void BusinessContext_IsPublic_Test()
        {
            Assert.IsTrue(typeof(BusinessContext).IsPublic);
        }

        [TestMethod]
        public void BusinessContext_IsSealed_Test()
        {
            Assert.IsTrue(typeof(BusinessContext).IsSealed);
        }

        [TestMethod]
        public void UpdateEntity_Test()
        {
        }

        [TestMethod]
        public void DeleteEntity_Test()
        {
        }
        //[TestMethod]
        //public void InsertAllObjectDb_Test()
        //{
        //    var listObject = new List<IEntity>()
        //    {
        //        new User { Username = "Denis2", Password = "999" },
        //        new Service { NameService = "AO-service-report"}

        //    };
        //    using (var bc = new BusinessContext(new TestMode()))
        //    {
        //        foreach (var objEntity in listObject)
        //        {
        //            var resultObject = bc.Add(objEntity);
        //            Assert.IsTrue(resultObject.Id > 0);
        //        }

        //    }
        //}
        //[TestMethod]
        //public void GetAllObjectDb_Test()
        //{
        //    var listObject = new Dictionary<Type, IEntity>()
        //    {
        //        { typeof(User),new User { Username = "Denis2", Password = "999" }},
        //        { typeof(Service),new Service { NameService = "AO-service-report"}}

        //    };

        //    //var listObject = new List<IEntity>()
        //    //{
        //    //    new User { Username = "Denis2", Password = "999" },
        //    //    new Service { NameService = "AO-service-report"}

        //    //};
        //    foreach (var entity in listObject)
        //    {
        //        var type = entity.Key;
        //        InsertAnyEntity_Test(entity.Value );
        //        GetAnyEntity_Test(entity);
        //    }
            
        //}

        //private void InsertAnyEntity_Test(IEntity entity)

        //{
        //    using (var bc = new BusinessContext(new TestMode()))
        //    {
        //        var resultObject = bc.Add(entity);
        //        Assert.IsTrue(resultObject.Id > 0);
        //    }
        //}

        //private void GetAnyEntity_Test<T>(T entity)
        //    where T: class, IEntity

        //{
        //    using (var bc = new BusinessContext(new TestMode()))
        //    {
        //        var resultObject = bc.Add(entity);
        //        var result = bc.Get<T, int>(resultObject.Id);
        //        Assert.IsNotNull(result);
        //        Assert.IsTrue(result.Id > 0);
        //    }
        //}

        [TestMethod]
        public void User_InsertEntity_Test(
            )
        {
  
            using (var bc = new BusinessContext(new TestMode()))
            {
                var resultObject = bc.Add(new User {Username = "Denis", Password = "999"});
                Assert.IsTrue(resultObject.Id > 0);
            }
        }

        [TestMethod]
        public void User_GetEntity_Test()
        {
            using (var bc = new BusinessContext(new TestMode()))
            {
                var resultObject = bc.Add(new User { Username = "Denis", Password = "999" });
                var result = bc.Get<User,int>(resultObject.Id);
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Id > 0);
            }
        }


        [TestMethod]
        public void Service_InsertEntity_Test(
        )
        {

            using (var bc = new BusinessContext(new TestMode()))
            {
                var resultObject = bc.Add(new Service { NameService = "AO-service-report" });
                Assert.IsTrue(resultObject.Id > 0);
            }
        }

        [TestMethod]
        public void Sevice_GetEntity_Test()
        {
            using (var bc = new BusinessContext(new TestMode()))
            {
                var resultObject = bc.Add(new Service { NameService = "AO-service-report" });
                var result = bc.Get<Service, int>(resultObject.Id);
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Id > 0);
            }
        }
    }
}