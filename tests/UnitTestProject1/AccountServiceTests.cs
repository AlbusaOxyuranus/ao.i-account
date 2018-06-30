using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.AccountServiceReference;

namespace UnitTestProject1
{
    [TestClass]
    public class AccountServiceTests
    {
        [TestMethod]
        public void CreateUser_Test()
        {
            var client = new AccountServiceClient();
            client.CreateUser(new User {Username = "denis-service", Password = "password"});
        }

        [TestMethod]
        public void GetUser_Test()
        {
            var client = new AccountServiceClient();
            var user = client.CreateUser(new User {Username = "denis-service", Password = "password"});
            client.GetUser(user.UserId);
        }
    }
}