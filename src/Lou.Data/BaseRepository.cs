using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Lou.Data
{
    public class BaseRepository<T> where T : Entity
    {
        public String ConnectionString { get; set; }

        public BaseRepository()
        {
            this.ConnectionString = DataAccess.ConnectionString;
        }
        public IDbConnection Connection => new SqlConnection(ConnectionString);
        public string TableName => GetTableName();
        public IEnumerable<T> GetAll()
        {
            using (var dbConnection = Connection) {
                return dbConnection.Query<T>($"select * from {GetTableName()}");
            }
        }
        public T GetById(int id)
        {
            using (var dbConnection = Connection) {
                return dbConnection.QueryFirst<T>($"select top 1 * from {TableName}");
            }
        }

        #region 私有方法
        private string GetTableName()
        {
            var type = typeof(T);
            return "Employee";
        }

        #endregion
    }
}
