using System;
using ao.i_account.service.dal;

namespace ao.i_account.service.bal
{
    public sealed class BusinessContext : IBusinessContext
    {
        public BusinessContext()
        {
            DataContext = new DataContext();
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

        public TIEntity Add<TIEntity>()
        {
            throw new NotImplementedException();
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