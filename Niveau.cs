using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation_Eleve
{
    class Niveau
    {
        private int id;
        private string niveauScolaire;


        public Niveau(int id , string niveauScolaire) {
            this.id = id;
            this.niveauScolaire = niveauScolaire;
        }

        public string NiveauScolaire
        {
            get { return niveauScolaire; }
            set { niveauScolaire = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
