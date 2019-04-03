using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alimentation_Eleve
{
    class TableEnseignant
    {
        private MySqlConnection cnx;

        public TableEnseignant()
        {
            cnx = ConnectionMySql.GetConnection();
        }

        public Enseignant GetByLogin(string login)
        {

            cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand();

            cmdSql.Connection = cnx;
            cmdSql.CommandText = "select * from enseignant where login=@login";
            cmdSql.CommandType = CommandType.Text;
            cmdSql.Parameters.Add("@login", MySqlDbType.String);
            cmdSql.Parameters["@login"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@login"].Value = login;


            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {
                Enseignant unEnseignant = new Enseignant((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
                cnx.Close();
                return unEnseignant;
            }

            cnx.Close();
            return null;
        }
    }
}
