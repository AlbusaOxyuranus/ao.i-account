using System;
using ao.i_account.service.dal;

namespace ao.i_account.service.bal
{
    public sealed class BusinessContext : IBusinessContext
    {
        public BusinessContext(IMode mode)
        {
            var connectionString = mode.ConnectionString;
            DataContext = new DataContext(connectionString);
        }

        private IDataContext DataContext { get; }

        #region implementation IDisposable

        private readonly bool _disposed = false;


        public void Dispose()
        {
            Dispose(true);
            // ReSharper disable once GCSuppressFinalizeForTypeWithoutDestructor
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed || !disposing)
                return;

            DataContext?.Dispose();
        }

        #endregion

        public TIEntity Add<TIEntity>(TIEntity entity)
        {
           return DataContext.Insert(entity);
        }

        public TIEntity Get<TIEntity>()
        {
            throw new NotImplementedException();
        }

        public void Update<TIEntity>()
        {
            throw new NotImplementedException();
        }

        public void Delete<TIEntity>()
        {
            throw new NotImplementedException();
        }
    }
}