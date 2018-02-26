using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using lost_woods.Models;
using Microsoft.Extensions.Options;

namespace lost_woods
{
    public class TrailFactory
    {
        // C# IdbConnection is connection object for db
        // MySqlConnection is mysql connection equivalent
        // public IDbConnection Connection
        // {
        //     get{
        //         return new MySqlConnection;
        //         }

        private IOptions<MySqlOptions> _options;
        //accessing MVC to set above attribute using what we passed.
        public TrailFactory(IOptions<MySqlOptions> options)
        {
            // what is optionsvalue
            _options = options;
        }
        private IDbConnection Connection{
            get{ 
                return new MySqlConnection(_options.Value.ConnectionString);
            }
        }

        public List<Trail> GetTrails()
        {
            // using automatically closes after code
            using (IDbConnection connector = Connection)
            {
                var query = $"SELECT * from trails";
                var result = connector.Query<Trail>(query).ToList();
                return result;
            }
        }
    }
}