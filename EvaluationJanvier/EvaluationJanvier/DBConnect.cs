using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EvaluationJanvier
{
    internal class DBConnect
    {
        private string user;
        private string password;
        private string dbName;
        private string server;
        private MySqlConnection conn;


        public DBConnect()
        {
            initilize();
        }

        // Créer la connexion à la base de données
        private void initilize()
        {
            user = "root";
            password = "";
            dbName = "bdproduitjanvier";
            server = "localhost";

            string connexion = "SERVER=" + server + ";"
                + "DATABASE=" + dbName + ";"
                + "UID=" + user + ";"
                + "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connexion);
        }

        // ouvrir une connexion à la base de données client_ms
        private bool OpenConnexion()
        {
            try
            {
                conn.Open();
                return true;

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Problème de connnexion !!");
                        break;
                    case 1045:
                        MessageBox.Show("Login ou Mot de pass incorrecte !");
                        break;
                }

                return false;
            }
        }

        public void Insert(Produit p)
        {
            // définir la requête 
            string request = "INSERT INTO produit(code, nomProduit, categorie, prixUnitaire, dateFabrication, fournisseur, adresseFournisseur)"
                + " VALUES(" + p.Code + ", '" + p.NomProduit + "', '" + p.Categorie + "', '" + p.PrixUnitaire + "', '" + p.DateFabrication + "', '" + p.Fournisseur + "', '" + p.AdresseFournisseur + "')";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }
    }
}
