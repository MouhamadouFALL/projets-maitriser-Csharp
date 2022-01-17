namespace projet19_managerProduct
{
    partial class product
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
            this.codeP = new System.Windows.Forms.Label();
            this.labelNomP = new System.Windows.Forms.Label();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.labelPrixUnitaire = new System.Windows.Forms.Label();
            this.labelDateFabrication = new System.Windows.Forms.Label();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.labelAdresseFournisseur = new System.Windows.Forms.Label();
            this.codeProduit = new System.Windows.Forms.TextBox();
            this.nomProduit = new System.Windows.Forms.TextBox();
            this.categorie = new System.Windows.Forms.TextBox();
            this.prixUnitaire = new System.Windows.Forms.TextBox();
            this.dateFabrication = new System.Windows.Forms.TextBox();
            this.fournisseur = new System.Windows.Forms.TextBox();
            this.adresseFournisseur = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSaved = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Product";
            // 
            // codeP
            // 
            this.codeP.AutoSize = true;
            this.codeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeP.Location = new System.Drawing.Point(12, 88);
            this.codeP.Name = "codeP";
            this.codeP.Size = new System.Drawing.Size(101, 20);
            this.codeP.TabIndex = 1;
            this.codeP.Text = "Code Produit";
            // 
            // labelNomP
            // 
            this.labelNomP.AutoSize = true;
            this.labelNomP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomP.Location = new System.Drawing.Point(12, 122);
            this.labelNomP.Name = "labelNomP";
            this.labelNomP.Size = new System.Drawing.Size(96, 20);
            this.labelNomP.TabIndex = 2;
            this.labelNomP.Text = "Nom Produit";
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.Location = new System.Drawing.Point(12, 157);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(78, 20);
            this.labelCategorie.TabIndex = 3;
            this.labelCategorie.Text = "Categorie";
            // 
            // labelPrixUnitaire
            // 
            this.labelPrixUnitaire.AutoSize = true;
            this.labelPrixUnitaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixUnitaire.Location = new System.Drawing.Point(12, 192);
            this.labelPrixUnitaire.Name = "labelPrixUnitaire";
            this.labelPrixUnitaire.Size = new System.Drawing.Size(93, 20);
            this.labelPrixUnitaire.TabIndex = 4;
            this.labelPrixUnitaire.Text = "Prix Unitaire";
            // 
            // labelDateFabrication
            // 
            this.labelDateFabrication.AutoSize = true;
            this.labelDateFabrication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFabrication.Location = new System.Drawing.Point(12, 227);
            this.labelDateFabrication.Name = "labelDateFabrication";
            this.labelDateFabrication.Size = new System.Drawing.Size(127, 20);
            this.labelDateFabrication.TabIndex = 5;
            this.labelDateFabrication.Text = "Date Fabrication";
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFournisseur.Location = new System.Drawing.Point(12, 261);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(93, 20);
            this.labelFournisseur.TabIndex = 6;
            this.labelFournisseur.Text = "Fournisseur";
            // 
            // labelAdresseFournisseur
            // 
            this.labelAdresseFournisseur.AutoSize = true;
            this.labelAdresseFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresseFournisseur.Location = new System.Drawing.Point(12, 294);
            this.labelAdresseFournisseur.Name = "labelAdresseFournisseur";
            this.labelAdresseFournisseur.Size = new System.Drawing.Size(156, 20);
            this.labelAdresseFournisseur.TabIndex = 7;
            this.labelAdresseFournisseur.Text = "Adresse Fournisseur";
            // 
            // codeProduit
            // 
            this.codeProduit.Location = new System.Drawing.Point(401, 88);
            this.codeProduit.Name = "codeProduit";
            this.codeProduit.Size = new System.Drawing.Size(100, 20);
            this.codeProduit.TabIndex = 8;
            // 
            // nomProduit
            // 
            this.nomProduit.Location = new System.Drawing.Point(401, 122);
            this.nomProduit.Name = "nomProduit";
            this.nomProduit.Size = new System.Drawing.Size(100, 20);
            this.nomProduit.TabIndex = 9;
            // 
            // categorie
            // 
            this.categorie.Location = new System.Drawing.Point(401, 157);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(100, 20);
            this.categorie.TabIndex = 10;
            // 
            // prixUnitaire
            // 
            this.prixUnitaire.Location = new System.Drawing.Point(401, 192);
            this.prixUnitaire.Name = "prixUnitaire";
            this.prixUnitaire.Size = new System.Drawing.Size(100, 20);
            this.prixUnitaire.TabIndex = 11;
            // 
            // dateFabrication
            // 
            this.dateFabrication.Location = new System.Drawing.Point(401, 227);
            this.dateFabrication.Name = "dateFabrication";
            this.dateFabrication.Size = new System.Drawing.Size(100, 20);
            this.dateFabrication.TabIndex = 12;
            // 
            // fournisseur
            // 
            this.fournisseur.Location = new System.Drawing.Point(401, 261);
            this.fournisseur.Name = "fournisseur";
            this.fournisseur.Size = new System.Drawing.Size(100, 20);
            this.fournisseur.TabIndex = 13;
            // 
            // adresseFournisseur
            // 
            this.adresseFournisseur.Location = new System.Drawing.Point(401, 294);
            this.adresseFournisseur.Name = "adresseFournisseur";
            this.adresseFournisseur.Size = new System.Drawing.Size(100, 20);
            this.adresseFournisseur.TabIndex = 14;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(12, 340);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(99, 34);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(156, 398);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 34);
            this.btnQuit.TabIndex = 16;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(402, 397);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 35);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSaved
            // 
            this.labelSaved.AutoSize = true;
            this.labelSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaved.Location = new System.Drawing.Point(129, 202);
            this.labelSaved.Name = "labelSaved";
            this.labelSaved.Size = new System.Drawing.Size(246, 20);
            this.labelSaved.TabIndex = 19;
            this.labelSaved.Text = "Votre prduit a été bien enregistrer";
            this.labelSaved.Visible = false;
            this.labelSaved.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(287, 398);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(88, 34);
            this.btnList.TabIndex = 20;
            this.btnList.Text = "Afficher Liste";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 456);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.labelSaved);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.adresseFournisseur);
            this.Controls.Add(this.fournisseur);
            this.Controls.Add(this.dateFabrication);
            this.Controls.Add(this.prixUnitaire);
            this.Controls.Add(this.categorie);
            this.Controls.Add(this.nomProduit);
            this.Controls.Add(this.codeProduit);
            this.Controls.Add(this.labelAdresseFournisseur);
            this.Controls.Add(this.labelFournisseur);
            this.Controls.Add(this.labelDateFabrication);
            this.Controls.Add(this.labelPrixUnitaire);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.labelNomP);
            this.Controls.Add(this.codeP);
            this.Controls.Add(this.label1);
            this.Name = "product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label codeP;
        private System.Windows.Forms.Label labelNomP;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelPrixUnitaire;
        private System.Windows.Forms.Label labelDateFabrication;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.Label labelAdresseFournisseur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSaved;
        private System.Windows.Forms.Button btnList;
        public System.Windows.Forms.TextBox codeProduit;
        public System.Windows.Forms.TextBox nomProduit;
        public System.Windows.Forms.TextBox categorie;
        public System.Windows.Forms.TextBox prixUnitaire;
        public System.Windows.Forms.TextBox dateFabrication;
        public System.Windows.Forms.TextBox fournisseur;
        public System.Windows.Forms.TextBox adresseFournisseur;
    }
}