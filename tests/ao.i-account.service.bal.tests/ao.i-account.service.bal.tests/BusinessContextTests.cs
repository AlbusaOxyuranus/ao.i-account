using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ao.i_account.service.bal.tests
{
    [TestClass]
    public class BusinessContextTests
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
        public void InsertEntity_Test()
        {
        }

        [TestMethod]
        public void Get_Test()
        {
        }
    }
}