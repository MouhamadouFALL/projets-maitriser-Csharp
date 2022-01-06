using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationJanvier
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Produit produit = new Produit();
            
            produit.Code = int.Parse(code.Text);
            produit.NomProduit = nomProduit.Text;
            produit.Categorie = categorie.Text;
            produit.PrixUnitaire = int.Parse(prixUnitaire.Text);
            produit.DateFabrication = dateFabrication.Text;
            produit.Fournisseur = fournisseur.Text;
            produit.AdresseFournisseur = adresseFournisseur.Text;

            // Inserer à la base
            DBConnect dbconnect = new DBConnect();
            dbconnect.Insert(produit);

            code.Visible = false;
            nomProduit.Visible = false;
            categorie.Visible = false;
            prixUnitaire.Visible = false;
            dateFabrication.Visible = false;
            fournisseur.Visible = false;
            adresseFournisseur.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            code.Text = null;
            nomProduit.Text = null;
            categorie.Text = null;
            prixUnitaire.Text = null;
            dateFabrication.Text = null;
            fournisseur.Text = null;
            adresseFournisseur.Text = null;
        }
    }
}
