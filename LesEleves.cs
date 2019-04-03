using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Alimentation_Eleve
{
    class LesEleves
    {
        private List<Eleve> desEleves;

        public List<Eleve> DesEleves
        {
            get { return desEleves; }
            set { desEleves = value; }
        }


        public new string ToString()
        {
            string result = "";

            foreach (Eleve L in desEleves)
            {
                result = result + L.ToString() + "\n";
            }

            return result;
        }

        public LesEleves()
        {
            desEleves = new List<Eleve>();
        }

        public void CreateCsvPassWordFile(string chemin)
        {

            StreamWriter sw;
            sw = new StreamWriter(chemin);

            foreach(Eleve unEleve in desEleves)
            {
                sw.WriteLine(unEleve.ToString());
            }

            sw.Close();
        }


        public List<Eleve> LoadCsv(PassWordType type, string chemin) {

            StreamReader sr;
            sr = new StreamReader(chemin);

            string s = sr.ReadLine();

            string login,prenom;
            while (s != null)
            {
                string[] lineSplit = s.Split(';');
                // construction du login
                prenom = lineSplit[0];
                login = prenom[0] + lineSplit[1];

                Eleve unEleve = new Eleve(lineSplit[0], lineSplit[1], login + "@sio.jjr.fr", "");

                unEleve.PassWord = unEleve.GetNewPassWord(type);

                desEleves.Add(unEleve);

                s = sr.ReadLine();
            }

            sr.Close();
            return desEleves;
        }
    }
}
