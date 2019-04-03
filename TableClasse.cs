using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alimentation_Eleve
{
    class TableClasse
    {
        private MySqlConnection cnx;

        public TableClasse()
        {
            cnx = ConnectionMySql.GetConnection();
        }

        public void Insert(Classe uneClasse)
        {

            cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand();
            
            cmdSql.Connection = cnx;
            cmdSql.CommandText = "insert into classe (idEnseignant,anneeScolaire,idNiveau) values (@idEnseignant,@anneeScolaire,@idNiveau);";
            cmdSql.CommandType = CommandType.Text;

            cmdSql.Parameters.Add("@idEnseignant", MySqlDbType.Int32);
            cmdSql.Parameters["@idEnseignant"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@idEnseignant"].Value = uneClasse.IdEnseignant;

            cmdSql.Parameters.Add("@anneeScolaire", MySqlDbType.String);
            cmdSql.Parameters["@anneeScolaire"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@anneeScolaire"].Value = uneClasse.AnneeScolaire;

            cmdSql.Parameters.Add("@idNiveau", MySqlDbType.Int32);
            cmdSql.Parameters["@idNiveau"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["@idNiveau"].Value = uneClasse.IdNiveau;


            cmdSql.ExecuteNonQuery();

            cnx.Close();
        }




    }
}
