using System;

namespace ao.i_account.service.dal
{
    public class DataContext : IDataContext
    {
        #region   implementation IDisposable

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}