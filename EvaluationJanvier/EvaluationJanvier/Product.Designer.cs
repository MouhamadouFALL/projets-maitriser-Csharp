namespace EvaluationJanvier
{
    partial class Product
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.nomProduit = new System.Windows.Forms.TextBox();
            this.categorie = new System.Windows.Forms.TextBox();
            this.prixUnitaire = new System.Windows.Forms.TextBox();
            this.dateFabrication = new System.Windows.Forms.TextBox();
            this.fournisseur = new System.Windows.Forms.TextBox();
            this.adresseFournisseur = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom Produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prix unitaire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Fabrication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fournisseur";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Adresse Fournisseur";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(387, 65);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(100, 20);
            this.code.TabIndex = 8;
            // 
            // nomProduit
            // 
            this.nomProduit.Location = new System.Drawing.Point(387, 95);
            this.nomProduit.Name = "nomProduit";
            this.nomProduit.Size = new System.Drawing.Size(100, 20);
            this.nomProduit.TabIndex = 9;
            // 
            // categorie
            // 
            this.categorie.Location = new System.Drawing.Point(387, 122);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(100, 20);
            this.categorie.TabIndex = 10;
            // 
            // prixUnitaire
            // 
            this.prixUnitaire.Location = new System.Drawing.Point(387, 154);
            this.prixUnitaire.Name = "prixUnitaire";
            this.prixUnitaire.Size = new System.Drawing.Size(100, 20);
            this.prixUnitaire.TabIndex = 11;
            // 
            // dateFabrication
            // 
            this.dateFabrication.Location = new System.Drawing.Point(387, 182);
            this.dateFabrication.Name = "dateFabrication";
            this.dateFabrication.Size = new System.Drawing.Size(100, 20);
            this.dateFabrication.TabIndex = 12;
            // 
            // fournisseur
            // 
            this.fournisseur.Location = new System.Drawing.Point(387, 213);
            this.fournisseur.Name = "fournisseur";
            this.fournisseur.Size = new System.Drawing.Size(100, 20);
            this.fournisseur.TabIndex = 13;
            // 
            // adresseFournisseur
            // 
            this.adresseFournisseur.Location = new System.Drawing.Point(387, 246);
            this.adresseFournisseur.Name = "adresseFournisseur";
            this.adresseFournisseur.Size = new System.Drawing.Size(100, 20);
            this.adresseFournisseur.TabIndex = 14;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(38, 299);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(387, 299);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(205, 299);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 356);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.adresseFournisseur);
            this.Controls.Add(this.fournisseur);
            this.Controls.Add(this.dateFabrication);
            this.Controls.Add(this.prixUnitaire);
            this.Controls.Add(this.categorie);
            this.Controls.Add(this.nomProduit);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox nomProduit;
        private System.Windows.Forms.TextBox categorie;
        private System.Windows.Forms.TextBox prixUnitaire;
        private System.Windows.Forms.TextBox dateFabrication;
        private System.Windows.Forms.TextBox fournisseur;
        private System.Windows.Forms.TextBox adresseFournisseur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnQuit;
    }
}