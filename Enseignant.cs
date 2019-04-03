using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation_Eleve
{
    class Enseignant
    {
        private int id;
        private string nom;
        private string prenom;
        private string login;
        private string hashPassWord;

        public Enseignant(int id, string nom, string prenom, string login, string hashPassWord) {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.hashPassWord = hashPassWord;
        }
    }
}
