using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.AccountServiceReference;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateUser_Test()
        {
            var client = new AccountServiceClient();
            client.CreateUser(new User {Username = "denis-service", Password = "password"});
        }
    }
}