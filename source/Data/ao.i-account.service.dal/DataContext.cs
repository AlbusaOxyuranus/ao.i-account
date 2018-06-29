using System;

namespace ao.i_account.service.dal
{
    public class DataContext : IDataContext
    {
        public DataContext(string connectionString)
        {
            throw new NotImplementedException();
        }

        public TIEntity Insert<TIEntity>(TIEntity entity)
        {
            throw new NotImplementedException();
        }

        #region implementation IDisposable

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}