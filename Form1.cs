using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Alimentation_Eleve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.combox_repertoire.Click += new EventHandler(combox_repertoire_Click);
          //  btn_lancer.Click +=new EventHandler(btn_lancer_Click);
            this.cb_aleatoire.Click += new EventHandler(cb_aleatoire_Click);
            this.cb_construit.Click += new EventHandler(cb_construit_Click);
        }

        void cb_construit_Click(object sender, EventArgs e)
        {
            this.cb_aleatoire.Checked = false;
        }

        void cb_aleatoire_Click(object sender, EventArgs e)
        {
            this.cb_construit.Checked = false;
        }

        void combox_repertoire_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.combox_repertoire.Text = this.folderBrowserDialog1.SelectedPath;

            //this.openFileDialog1.ShowDialog();

            if (combox_repertoire.Text != "")
            {
                DirectoryInfo direction = new DirectoryInfo(@combox_repertoire.Text);
                FileInfo[] fichiers = direction.GetFiles("*.csv");

                foreach (FileInfo f in fichiers)
                {
                    clb_fichier_a_integrer.Items.Add(f);
                    
                }
            }

        }


        private void combox_repertoire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_lancer_Click(object sender, EventArgs e)
        {
            //clb_fichier_a_integrer.Items.Clear();

            if (combox_repertoire.Text != "")
            {
                LesEleves list = new LesEleves();
                TableEleve uneTableEl = new TableEleve();
                DirectoryInfo direction = new DirectoryInfo(@combox_repertoire.Text);
                FileInfo[] fichiers = direction.GetFiles("*.csv");

                foreach (FileInfo f in clb_fichier_a_integrer.CheckedItems)
                {


                    string chemin = f.FullName;

                    if (this.cb_aleatoire.Checked)
                    {
                        list.LoadCsv(PassWordType.Aleatoire, chemin);
                        list.CreateCsvPassWordFile(chemin);
                    }
                    else
                    {
                        if (this.cb_construit.Checked)
                        {
                            list.LoadCsv(PassWordType.Construit, chemin);
                            list.CreateCsvPassWordFile(chemin);
                        }
                    }
                }

                //foreach (Eleve E in list.DesEleves)
                //{
                //    uneTableEl.Insert(E);
                //}


                MessageBox.Show(list.ToString());
            }

        }

        private void combox_niveau_Click(object sender, EventArgs e)
        {
            combox_niveau.Items.Clear();
            TableNiveau uneTableNiveau = new TableNiveau();
            List<Niveau> listNiveau = uneTableNiveau.GetAll();
            foreach (Niveau unNiveau in listNiveau)
            {
                this.combox_niveau.Items.Add(unNiveau.NiveauScolaire);
            }
        }
    }
}
