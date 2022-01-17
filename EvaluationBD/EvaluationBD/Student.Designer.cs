namespace EvaluationBD
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.labelSaved = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dateNaissance = new System.Windows.Forms.TextBox();
            this.fliere = new System.Windows.Forms.TextBox();
            this.niveau = new System.Windows.Forms.TextBox();
            this.classe = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.matricule = new System.Windows.Forms.TextBox();
            this.labelAdresseFournisseur = new System.Windows.Forms.Label();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.labelDateFabrication = new System.Windows.Forms.Label();
            this.labelPrixUnitaire = new System.Windows.Forms.Label();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.nomEtu = new System.Windows.Forms.Label();
            this.codeP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.nationalite = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulaire Etudiant";
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(126, 435);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(88, 34);
            this.btnList.TabIndex = 40;
            this.btnList.Text = "Afficher Liste";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // labelSaved
            // 
            this.labelSaved.AutoSize = true;
            this.labelSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaved.Location = new System.Drawing.Point(343, 212);
            this.labelSaved.Name = "labelSaved";
            this.labelSaved.Size = new System.Drawing.Size(137, 20);
            this.labelSaved.TabIndex = 39;
            this.labelSaved.Text = "Bien enregistrer !!!";
            this.labelSaved.Visible = false;
            this.labelSaved.Click += new System.EventHandler(this.labelSaved_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(2, 435);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(95, 34);
            this.btnAjouter.TabIndex = 38;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(522, 434);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 35);
            this.btnAnnuler.TabIndex = 37;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(684, 434);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 34);
            this.btnQuit.TabIndex = 36;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(260, 436);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(99, 34);
            this.btnModifier.TabIndex = 35;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(684, 305);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(100, 20);
            this.dateNaissance.TabIndex = 34;
            // 
            // fliere
            // 
            this.fliere.Location = new System.Drawing.Point(684, 272);
            this.fliere.Name = "fliere";
            this.fliere.Size = new System.Drawing.Size(100, 20);
            this.fliere.TabIndex = 33;
            // 
            // niveau
            // 
            this.niveau.Location = new System.Drawing.Point(684, 238);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(100, 20);
            this.niveau.TabIndex = 32;
            // 
            // classe
            // 
            this.classe.Location = new System.Drawing.Point(684, 203);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(100, 20);
            this.classe.TabIndex = 31;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(684, 168);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 30;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(684, 133);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 29;
            // 
            // matricule
            // 
            this.matricule.Location = new System.Drawing.Point(684, 99);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(100, 20);
            this.matricule.TabIndex = 28;
            // 
            // labelAdresseFournisseur
            // 
            this.labelAdresseFournisseur.AutoSize = true;
            this.labelAdresseFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresseFournisseur.Location = new System.Drawing.Point(12, 305);
            this.labelAdresseFournisseur.Name = "labelAdresseFournisseur";
            this.labelAdresseFournisseur.Size = new System.Drawing.Size(122, 20);
            this.labelAdresseFournisseur.TabIndex = 27;
            this.labelAdresseFournisseur.Text = "Date Naissance";
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFournisseur.Location = new System.Drawing.Point(12, 272);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(48, 20);
            this.labelFournisseur.TabIndex = 26;
            this.labelFournisseur.Text = "Fliere";
            // 
            // labelDateFabrication
            // 
            this.labelDateFabrication.AutoSize = true;
            this.labelDateFabrication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFabrication.Location = new System.Drawing.Point(12, 238);
            this.labelDateFabrication.Name = "labelDateFabrication";
            this.labelDateFabrication.Size = new System.Drawing.Size(57, 20);
            this.labelDateFabrication.TabIndex = 25;
            this.labelDateFabrication.Text = "Niveau";
            // 
            // labelPrixUnitaire
            // 
            this.labelPrixUnitaire.AutoSize = true;
            this.labelPrixUnitaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixUnitaire.Location = new System.Drawing.Point(12, 203);
            this.labelPrixUnitaire.Name = "labelPrixUnitaire";
            this.labelPrixUnitaire.Size = new System.Drawing.Size(57, 20);
            this.labelPrixUnitaire.TabIndex = 24;
            this.labelPrixUnitaire.Text = "Classe";
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.Location = new System.Drawing.Point(12, 168);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(64, 20);
            this.labelCategorie.TabIndex = 23;
            this.labelCategorie.Text = "Prenom";
            // 
            // nomEtu
            // 
            this.nomEtu.AutoSize = true;
            this.nomEtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEtu.Location = new System.Drawing.Point(12, 133);
            this.nomEtu.Name = "nomEtu";
            this.nomEtu.Size = new System.Drawing.Size(42, 20);
            this.nomEtu.TabIndex = 22;
            this.nomEtu.Text = "Nom";
            // 
            // codeP
            // 
            this.codeP.AutoSize = true;
            this.codeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeP.Location = new System.Drawing.Point(12, 99);
            this.codeP.Name = "codeP";
            this.codeP.Size = new System.Drawing.Size(73, 20);
            this.codeP.TabIndex = 21;
            this.codeP.Text = "Matricule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Adrese";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nationalité";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(684, 347);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(100, 20);
            this.adresse.TabIndex = 43;
            // 
            // nationalite
            // 
            this.nationalite.Location = new System.Drawing.Point(684, 379);
            this.nationalite.Name = "nationalite";
            this.nationalite.Size = new System.Drawing.Size(100, 20);
            this.nationalite.TabIndex = 44;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(386, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 33);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(868, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 300);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.nationalite);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.labelSaved);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.fliere);
            this.Controls.Add(this.niveau);
            this.Controls.Add(this.classe);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.labelAdresseFournisseur);
            this.Controls.Add(this.labelFournisseur);
            this.Controls.Add(this.labelDateFabrication);
            this.Controls.Add(this.labelPrixUnitaire);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.nomEtu);
            this.Controls.Add(this.codeP);
            this.Controls.Add(this.label1);
            this.Name = "Student";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label labelSaved;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.TextBox dateNaissance;
        public System.Windows.Forms.TextBox fliere;
        public System.Windows.Forms.TextBox niveau;
        public System.Windows.Forms.TextBox classe;
        public System.Windows.Forms.TextBox prenom;
        public System.Windows.Forms.TextBox nom;
        public System.Windows.Forms.TextBox matricule;
        private System.Windows.Forms.Label labelAdresseFournisseur;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.Label labelDateFabrication;
        private System.Windows.Forms.Label labelPrixUnitaire;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label nomEtu;
        private System.Windows.Forms.Label codeP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox nationalite;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

