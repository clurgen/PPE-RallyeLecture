using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation_Eleve
{
    class Eleve
    {
        private string nom;
        private string prenom;
        private string login;
        private string passWord;
        static Random rnd = new Random();

        public Eleve(string nom, string prenom, string login, string passWord)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.passWord = passWord;
        }

        public new string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}", this.nom, this.prenom, this.login, this.passWord);
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public string GetPasswordAleatoire()
        {

            string alea = "";
            string lettre = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!§:/;.,?ù%*µ$£¤=+})°]à@ç^_è`-|(['{#é~&²<>";
            int lettreMinuscule = 0;
            int chiffre = 0;
            int lettreMajuscule = 0;
            int caractSpeciale = 0;
                                    
            for (int i = 0; i < 6; i++)
            { 
                char char1 = lettre[rnd.Next(0, 26)];

                    lettreMinuscule = lettreMinuscule + 1;
                    alea = alea + char1;
                
            }
            
            for (int i = 0; i < 1; i++)
            {
                char char1 = lettre[rnd.Next(27, 52)];

                    lettreMajuscule = lettreMajuscule + 1;
                    alea = alea + char1;
                
            }
            
            for (int i = 0; i < 1; i++)
            {
                char char1 = lettre[rnd.Next(53, 62)];
                    chiffre = chiffre + 1;
                    alea = alea + char1;
                
            }
                                    
            for (int i = 0; i < 1; i++)
            {
                char char1 = lettre[rnd.Next(63, 103)];

                    caractSpeciale = caractSpeciale + 1;
                    alea = alea + char1;
                
            }
                        
            return alea;
        }


        public string GetPassWordConstruit()
        {
            return this.prenom[0] + this.nom;
        }


        public string GetNewPassWord(PassWordType passWord)
        {
            if (passWord == PassWordType.Aleatoire)
            {
                return this.GetPasswordAleatoire();
            }
            else
            {
                if (passWord == PassWordType.Construit)
                {
                    return this.GetPassWordConstruit();
                }
            }
            return null;
        }
    }
}
