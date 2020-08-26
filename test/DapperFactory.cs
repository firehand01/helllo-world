using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinCrud.Orm
{
    public class DapperFactory
    {
        public static OracleConnection CrateOracleConnection(string connectionString)
        {
            var connection = new OracleConnection(connectionString);
            return connection;
        }
    }
}
