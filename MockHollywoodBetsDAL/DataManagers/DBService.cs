using MockHollywoodBetsDAL.DataManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockHollywoodBetsDAL.Models;
using System.Data.SqlClient;

namespace MockHollywoodBetsDAL.DataManagers
{
    public class DBService : IDataBase
    {
        private MockHollywoodBetsContext _dbContext;

        private static readonly string connectionString = "Server=DESKTOP-AER3FMQ\\SQLEXPRESS01;Database=MockHollywoodBets;Trusted_Connection=True;";

        public DBService(MockHollywoodBetsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MockHollywoodBetsContext dbContext()
        {
            return _dbContext;
        }

        public static SqlConnection GetSqlConnection()
        {
            var connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
