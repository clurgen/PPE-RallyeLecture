using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alimentation_Eleve
{
    class TableEleve
    {
         private MySqlConnection cnx;

         public TableEleve()
        {
            cnx = ConnectionMySql.GetConnection();
        }

        public void Insert(Eleve unEleve)
        {

            cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand();

            cmdSql.Connection = cnx; cmdSql.CommandText = "insert into eleve (nom,prenom,login,passWord) values (@nom,@prenom,@login);";
            cmdSql.CommandType = CommandType.Text;

            cmdSql.Parameters.Add("@nom", MySqlDbType.String);
            cmdSql.Parameters["@nom"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@nom"].Value = unEleve.Nom;

            cmdSql.Parameters.Add("@prenom", MySqlDbType.String);
            cmdSql.Parameters["@prenom"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@prenom"].Value = unEleve.Prenom;

            cmdSql.Parameters.Add("@login", MySqlDbType.String);
            cmdSql.Parameters["@login"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@login"].Value = unEleve.Login;


            cmdSql.ExecuteNonQuery();

            cnx.Close();

            
        }
    }
}
