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
    public partial class View : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;

        int id;
        public View()
        {
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            product product = new product();

            product.Visible = true;
            this.Hide();
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();

            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            DBConnect dbconnect = new DBConnect();
            adpt = dBConnect.ReadProducts();
            adpt.Fill(dt);
            
        }
        public void dispay()
        {
            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            DBConnect dbconnect = new DBConnect();
            adpt = dbconnect.ReadProducts();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product product = new product();

            if (product.codeProduit.Text == "" || product.nomProduit.Text == "" || product.categorie.Text == "" || product.prixUnitaire.Text == "" || product.dateFabrication.Text == "" || product.fournisseur.Text == "" || product.adresseFournisseur.Text == "")
            {
                MessageBox.Show("Please Fill in the Blanks !!!");

            }
            else
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                product.codeProduit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.nomProduit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.categorie.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                product.prixUnitaire.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.dateFabrication.Text =  dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.fournisseur.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                product.adresseFournisseur.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                // Inserer à la base
                //DBConnect dbconnect = new DBConnect();
                //dbconnect.Update(produit, ID);

                //MessageBox.Show("Produit bien Modifier ");
                //clear();
                //dispay();

                //product p = new product();
                

                // ListView.SelectedListViewItemCollection selecProduits = listView1.SelectedItems;

                // foreach (ListViewItem element in selecProduits)
                // {
                // product.codeProduit.Text = element.Text;
                // }

                // this.dataGridView1_CellContentClick();

                //p.Visible = true;
                //this.Hide();
            }
        }

        private void btnModification_Click(object sender, EventArgs e)
        {
            product product = new product();

            if (product.codeProduit.Text == "" || product.nomProduit.Text == "" || product.categorie.Text == "" || product.prixUnitaire.Text == "" || product.dateFabrication.Text == "" || product.fournisseur.Text == "" || product.adresseFournisseur.Text == "")
            {
                MessageBox.Show(" Please Fill in the Blanks");

            }
            else
            {
                etu.Nom = nom.Text.Trim();
                etu.Prenom = prenom.Text.Trim();
                etu.Classe = classe.Text.Trim();
                etu.Niveau = niveau.Text.Trim();
                etu.Fliere = fliere.Text.Trim();
                etu.DateNaissance = dateNaissance.Text.Trim();
                etu.Adresse = adresse.Text.Trim();
                etu.Nationalite = nationalite.Text.Trim();

                // Inserer à la base
                DBConnect dbconnect = new DBConnect();
                dbconnect.Update(etu, id);

                MessageBox.Show(" Modifier etudiant ok");
                clear();
                dispay();
            }
        }
    }
}
