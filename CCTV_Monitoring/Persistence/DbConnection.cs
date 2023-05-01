using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTV_Monitoring
{
    public static class DbConnection
    {
        public async static Task<List<AppCheckAlertRequest>> GetAppChecks()
        {

            string[] connectionString = File.ReadAllLines("DbConnection.txt");

            var host = connectionString[0];
            var dbName = connectionString[1];
            var table = connectionString[2];
            var username = connectionString[3];
            var password = connectionString[4];

            using (var connection = new MySqlConnection($"Server={host};Database={dbName};Uid={username};Pwd={password};"))
            {

                var sql = $"SELECT ac.id, ac.name, ac.timeout, ac.host, ac.status, ac.type, ac.on_map, ac.lat, ac.lng FROM {table} ac";
                var result = (await connection.QueryAsync<AppCheckAlertRequest>(sql).ConfigureAwait(false)).AsList();
                return result;
            }


        }
       
    }
}
