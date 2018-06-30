using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ao.i_account.service.bal.tests
{
    //[TestClass]
    public class FunctionalTest
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            //using (var bc = new BusinessContext(new TestMode()))
            //{
            //    if (bc.Database.ExistDatabase("i-account-tests.db"))
            //        bc.Database.DeleteDatabase("i-account-tests.db");
            //    bc.Database.CreateDatabase("i-account-tests.db");
            //}
        }

        [TestCleanup]
        public virtual void TestCleanup()
        {
            //using (var bc = new BusinessContext(new TestMode()))
            //{
            //    if (bc.Database.ExistDatabase("i-account-tests.db"))
            //        bc.Database.DeleteDatabase("i-account-tests.db");
            //}
        }
    }
}