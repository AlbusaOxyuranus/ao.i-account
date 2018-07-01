using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ao.i_account.service.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ao.i_account.service.bal.tests
{
    [TestClass]
    public class BusinessContextPrepareDatabaseTests
    {
        [TestMethod]
        public void Prepare()
        {
            using (var bc = new BusinessContext(new TestMode()))
            {
                var resultObject = bc.Add(new Service { NameService = "XCS-BY.AO.Service.i-Business" });
                Assert.IsTrue(resultObject.Id > 0);
                var resultObject2 = bc.Add(new Service { NameService = "XCS-BY.AO.Service.i-Mail" });
                Assert.IsTrue(resultObject2.Id > 0);
                var resultObject3 = bc.Add(new Service { NameService = "XCS-BY.AO.Service.i-Write" });
                Assert.IsTrue(resultObject2.Id > 0);
                var resultObject4 = bc.Add(new Service { NameService = "XCS-BY.AO.Service.i-Film" });
                Assert.IsTrue(resultObject4.Id > 0);
            }
        }
    }
}
