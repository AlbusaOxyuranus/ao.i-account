using System;
using ao.i_account.service.models;

namespace ao.i_account.service.dal
{
    public interface IDataContext : IDisposable
    {
        TEntity Insert<TEntity>(TEntity entity) where TEntity : class, IEntity;
    }
}