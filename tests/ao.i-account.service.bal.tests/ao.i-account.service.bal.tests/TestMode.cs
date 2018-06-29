using ao.i_account.service.dal;
using System.Configuration;

namespace ao.i_account.service.bal.tests
{
    public class TestMode : IMode
    {
        public string ConnectionString => ConfigurationManager.ConnectionStrings["Test-db"].ConnectionString;
    }
}
