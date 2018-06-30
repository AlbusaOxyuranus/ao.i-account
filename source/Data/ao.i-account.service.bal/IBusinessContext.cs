using System;
using ao.i_account.service.dal;
using ao.i_account.service.models;

namespace ao.i_account.service.bal
{
    public interface IBusinessContext : IDisposable
    {
        TEntity Add<TEntity>(TEntity entity) where TEntity : class, IEntity;
        TIEntity Get<TIEntity, TGetType>(TGetType id);
        void Update<TIEntity>();
        void Delete<TIEntity>();
        Database Database { get; }
    }
}