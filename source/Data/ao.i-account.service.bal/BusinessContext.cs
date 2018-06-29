using ao.i_account.service.dal;

namespace ao.i_account.service.bal
{
    public class BusinessContext
    {
        public BusinessContext()
        {
            DataContext = new DataContext();
        }

        public DataContext DataContext { get; protected set; }
    }
}