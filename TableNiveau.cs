using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alimentation_Eleve
{
    class TableNiveau
    {
         private MySqlConnection cnx;

         public TableNiveau()
        {
            cnx = ConnectionMySql.GetConnection();
        }

        public List<Niveau> GetAll()
        {

            cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand();

            cmdSql.Connection = cnx;
            cmdSql.CommandText = "niveau";
            cmdSql.CommandType = CommandType.TableDirect;

            List<Niveau> lesNiveaux = new List<Niveau>();

            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {
                Niveau unNiveau = new Niveau((int)reader[0], (string)reader[1]);
                lesNiveaux.Add(unNiveau);
            }

            cnx.Close();
            return lesNiveaux;
        }


    }
}
