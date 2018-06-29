using System;

namespace ao.i_account.service.bal
{
    public interface IBusinessContext : IDisposable
    {
        TIEntity Add<TIEntity>(TIEntity entity);
        TIEntity Get<TIEntity>();
        void Update<TIEntity>();
        void Delete<TIEntity>();
    }
}