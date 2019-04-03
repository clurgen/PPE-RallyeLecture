using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Alimentation_Eleve
{
    static class ConnectionMySql
    {
        static private MySqlConnection connection;

        static ConnectionMySql() {
            connection = new MySqlConnection("user = root; password = siojjr; database = rallyeLecture; host = localhost");
        }

        static public MySqlConnection GetConnection() {
            return ConnectionMySql.connection;
        }
    }
}
