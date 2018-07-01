using System;
using System.Collections.Generic;
using System.Linq;
using ao.i_account.service.dal.Usp;
using ao.i_account.service.models;

namespace ao.i_account.service.dal
{
    public static class Mapper
    {
        private static readonly Dictionary<Type, Type> _mapDictionary = new Dictionary<Type, Type>()
        {
            {typeof(User), typeof(UserUspBase)},
            {typeof(Service), typeof(ServiceUspBase)},
        };

        public static UspBase InsertOperation(IEntity entity)
        {
            var type = _mapDictionary.Single(x => x.Key == entity.GetType()).Value;
            var sp = Activator.CreateInstance(type, Operation.Insert);
            sp.As<UspBase>().Parameters.Add("@json", entity.SerializeDataContract());
            return sp.As<UspBase>();

        }

        public static UspBase GetOperation<TEntity, TGetType>(TGetType id) where TEntity:IEntity
        {
            var type = _mapDictionary.Single(x => x.Key == typeof(TEntity)).Value;
            var sp = Activator.CreateInstance(type, Operation.Get);
            sp.As<UspBase>().Parameters.Add("@Id", id);
           return sp.As<UspBase>();
        }
    }
}