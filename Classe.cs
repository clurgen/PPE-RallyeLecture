using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation_Eleve
{
    class Classe
    {
        private int idEnseignant;
        private string anneeScolaire;
        private int idNiveau;

        public Classe(int idEnseignant, string anneeScolaire, int idNiveau) {
            this.idEnseignant = idEnseignant;
            this.anneeScolaire = anneeScolaire;
            this.idNiveau = idNiveau;
        }

        public int IdNiveau
        {
            get { return idNiveau; }
            set { idNiveau = value; }
        }

        public int IdEnseignant
        {
            get { return idEnseignant; }
            set { idEnseignant = value; }
        }

        public string AnneeScolaire
        {
            get { return anneeScolaire; }
            set { anneeScolaire = value; }
        }


    }
}
