using System;

namespace ao.i_account.service.dal
{
    public interface IDataContext : IDisposable
    {
        TIEntity Insert<TIEntity>(TIEntity entity);
    }
}