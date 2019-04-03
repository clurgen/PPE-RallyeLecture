namespace Alimentation_Eleve
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_aleatoire = new System.Windows.Forms.CheckBox();
            this.cb_construit = new System.Windows.Forms.CheckBox();
            this.clb_fichier_a_integrer = new System.Windows.Forms.CheckedListBox();
            this.tb_annee = new System.Windows.Forms.TextBox();
            this.combox_repertoire = new System.Windows.Forms.ComboBox();
            this.combox_niveau = new System.Windows.Forms.ComboBox();
            this.btn_lancer = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Répertoire des fichiers :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fichier csv à intégrer : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Année scolaire : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Niveau : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mot de passe : ";
            // 
            // cb_aleatoire
            // 
            this.cb_aleatoire.AutoSize = true;
            this.cb_aleatoire.Location = new System.Drawing.Point(138, 233);
            this.cb_aleatoire.Name = "cb_aleatoire";
            this.cb_aleatoire.Size = new System.Drawing.Size(67, 17);
            this.cb_aleatoire.TabIndex = 6;
            this.cb_aleatoire.Text = "Aléatoire";
            this.cb_aleatoire.UseVisualStyleBackColor = true;
            // 
            // cb_construit
            // 
            this.cb_construit.AutoSize = true;
            this.cb_construit.Location = new System.Drawing.Point(232, 229);
            this.cb_construit.Name = "cb_construit";
            this.cb_construit.Size = new System.Drawing.Size(67, 17);
            this.cb_construit.TabIndex = 7;
            this.cb_construit.Text = "Construit";
            this.cb_construit.UseVisualStyleBackColor = true;
            // 
            // clb_fichier_a_integrer
            // 
            this.clb_fichier_a_integrer.FormattingEnabled = true;
            this.clb_fichier_a_integrer.Location = new System.Drawing.Point(138, 43);
            this.clb_fichier_a_integrer.Name = "clb_fichier_a_integrer";
            this.clb_fichier_a_integrer.Size = new System.Drawing.Size(371, 109);
            this.clb_fichier_a_integrer.TabIndex = 8;
            // 
            // tb_annee
            // 
            this.tb_annee.Location = new System.Drawing.Point(138, 165);
            this.tb_annee.Name = "tb_annee";
            this.tb_annee.Size = new System.Drawing.Size(100, 20);
            this.tb_annee.TabIndex = 9;
            // 
            // combox_repertoire
            // 
            this.combox_repertoire.FormattingEnabled = true;
            this.combox_repertoire.Location = new System.Drawing.Point(138, 9);
            this.combox_repertoire.Name = "combox_repertoire";
            this.combox_repertoire.Size = new System.Drawing.Size(316, 21);
            this.combox_repertoire.TabIndex = 10;
            this.combox_repertoire.SelectedIndexChanged += new System.EventHandler(this.combox_repertoire_SelectedIndexChanged);
            // 
            // combox_niveau
            // 
            this.combox_niveau.FormattingEnabled = true;
            this.combox_niveau.Location = new System.Drawing.Point(138, 200);
            this.combox_niveau.Name = "combox_niveau";
            this.combox_niveau.Size = new System.Drawing.Size(161, 21);
            this.combox_niveau.TabIndex = 11;
            this.combox_niveau.Click += new System.EventHandler(this.combox_niveau_Click);
            // 
            // btn_lancer
            // 
            this.btn_lancer.Location = new System.Drawing.Point(138, 267);
            this.btn_lancer.Name = "btn_lancer";
            this.btn_lancer.Size = new System.Drawing.Size(130, 23);
            this.btn_lancer.TabIndex = 12;
            this.btn_lancer.Text = "Lancer l\'intégration";
            this.btn_lancer.UseVisualStyleBackColor = true;
            this.btn_lancer.Click += new System.EventHandler(this.btn_lancer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 302);
            this.Controls.Add(this.btn_lancer);
            this.Controls.Add(this.combox_niveau);
            this.Controls.Add(this.combox_repertoire);
            this.Controls.Add(this.tb_annee);
            this.Controls.Add(this.clb_fichier_a_integrer);
            this.Controls.Add(this.cb_construit);
            this.Controls.Add(this.cb_aleatoire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_aleatoire; 
        private System.Windows.Forms.CheckBox cb_construit;
        private System.Windows.Forms.CheckedListBox clb_fichier_a_integrer;
        private System.Windows.Forms.TextBox tb_annee;
        private System.Windows.Forms.ComboBox combox_repertoire;
        private System.Windows.Forms.ComboBox combox_niveau;
        private System.Windows.Forms.Button btn_lancer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

