using System;
using System.Data;
using System.Data.SqlClient;
using ao.i_account.service.models;

namespace ao.i_account.service.dal
{
    public class DataContext : IDataContext
    {
        private readonly string _connectionString;

        public DataContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public TEntity Insert<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
           var usp = Mapper.InsertOperation(entity);
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand(usp.NameUsp, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                foreach (var parameter in usp.Parameters) command.Parameters.Add(new SqlParameter(parameter.Key,parameter.Value));

                var insertedId = command.ExecuteScalar();

                if (insertedId == null)
                {
                    command.CommandText = usp.NameUsp;
                    insertedId = command.ExecuteScalar();
                }

                return default(TEntity); //int.Parse(insertedId.ToString());
            }
        }

        #region implementation IDisposable

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}