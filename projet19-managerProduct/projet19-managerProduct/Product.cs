using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace projet19_managerProduct
{
    public partial class product : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;

        public product()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // recupérer les saisies et les mettre dans l'objet Produit
            Produit produit = new Produit();

            produit.CodeProduit = codeProduit.Text.Trim();
            produit.NomProduit = nomProduit.Text.Trim();
            produit.Categorie  = categorie.Text.Trim();
            produit.PrixUnitaire = double.Parse(prixUnitaire.Text);
            produit.DateFabrication = dateFabrication.Text.Trim();
            produit.Fournisseur = fournisseur.Text.Trim();
            produit.AdresseFournisseur = adresseFournisseur.Text.Trim();

            // Inserer les données dans la base de données dbproduits
            DBConnect dBConnect = new DBConnect();
            dBConnect.Insert(produit);

            // Cacher les champs de saisie
            codeProduit.Visible = false;
            nomProduit.Visible=false;
            categorie.Visible=false;
            prixUnitaire.Visible=false;
            dateFabrication.Visible=false;
            fournisseur.Visible=false;
            adresseFournisseur.Visible = false;

            codeP.Visible=false;
            labelNomP.Visible = false;
            labelCategorie.Visible=false;
            labelPrixUnitaire.Visible = false;
            labelDateFabrication.Visible=false;
            labelFournisseur.Visible=false;
            labelAdresseFournisseur.Visible=false;

            // 
            labelSaved.Visible = true;

            //product.DefaultBackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelSaved.Visible=false;
            
            codeProduit.Text = null;
            nomProduit.Text = null;
            categorie.Text = null;
            prixUnitaire.Text = null;
            dateFabrication.Text = null;
            fournisseur.Text = null;
            adresseFournisseur.Text = null;

            codeProduit.Visible = true;
            nomProduit.Visible = true;
            categorie.Visible = true;
            prixUnitaire.Visible = true;
            dateFabrication.Visible = true;
            fournisseur.Visible = true;
            adresseFournisseur.Visible = true;

            codeP.Visible = true;
            labelNomP.Visible = true;
            labelCategorie.Visible = true;
            labelPrixUnitaire.Visible = true;
            labelDateFabrication.Visible = true;
            labelFournisseur.Visible = true;
            labelAdresseFournisseur.Visible = true;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            codeProduit.Text = null;
            nomProduit.Text = null;
            categorie.Text = null;
            prixUnitaire.Text = null;
            dateFabrication.Text = null;
            fournisseur.Text = null;
            adresseFournisseur.Text=null;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            // Redirection sur le formulaire d'affichage
            View view = new View();
            DBConnect dBConnect = new DBConnect();

            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            DBConnect dbconnect = new DBConnect();
            adpt = dbconnect.ReadProducts();
            adpt.Fill(dt);
            view.dataGridView1.DataSource = dt;

            // Solution 2
            ListViewItem listViewItem = new ListViewItem();



            view.Visible = true;
            this.Hide();

        }

        private void product_Load(object sender, EventArgs e)
        {
        }
    }
}
