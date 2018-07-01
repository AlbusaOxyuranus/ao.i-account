using System.Collections.Generic;
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
        [TestMethod]
        public void InsertAllObjectDb_Test()
        {
            var listObject = new List<IEntity>()
            {
                new User { Username = "Denis2", Password = "999" },
                new Service { NameService = "AO-service-report"}

            };
            using (var bc = new BusinessContext(new TestMode()))
            {
                foreach (var objEntity in listObject)
                {
                    var resultObject = bc.Add(objEntity);
                    Assert.IsTrue(resultObject.Id > 0);
                }
                
            }
        }

        [TestMethod]
        public void InsertEntity_Test()
        {
  
            using (var bc = new BusinessContext(new TestMode()))
            {
                var resultObject = bc.Add(new User {Username = "Denis", Password = "999"});
                Assert.IsTrue(resultObject.Id > 0);
            }
        }

        [TestMethod]
        public void Get_Test()
        {
            using (var bc = new BusinessContext(new TestMode()))
            {
                var resultObject = bc.Add(new User { Username = "Denis", Password = "999" });
                var result = bc.Get<User,int>(resultObject.Id);
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Id > 0);
            }
        }
    }
}