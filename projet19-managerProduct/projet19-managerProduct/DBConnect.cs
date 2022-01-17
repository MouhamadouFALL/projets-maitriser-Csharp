using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace projet19_managerProduct
{
    internal class DBConnect
    {
        private string user;
        private string password;
        private string dbName;
        private string server;
        private MySqlConnection conn;

        //
        MySqlDataAdapter mySqlDataAdp;
        MySqlDataAdapter mySqlDataAdpLogin;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            user = "root";
            password = "";
            dbName = "bdproduitjanvier";
            server = "localhost";

            string connexion = "SERVER=" +server+ ";"
                + "DATABASE="+dbName+";"
                + "UID="+user+";"
                + "PASSWORD="+password+";";

            conn = new MySqlConnection(connexion);
        }

        // ouvrir une session de connexion à la base de données
        private bool OpenConnexion()
        {
            try
            {
                conn.Open();
                return true;
            }catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0: MessageBox.Show("Problème de connexion !!");
                        break;
                    case 1045: MessageBox.Show("Login ou mot de passe incorrecte !!");
                        break;
                }

                return false;
            }
        }

        public void Insert(Produit p)
        {
            // Définir la requête d'insertion
            string request = "insert into produit(code, nomProduit, categorie, prixUnitaire, dateFabrication, fournisseur, adresseFournisseur) " 
                + "values('"+p.CodeProduit+ "', '" 
                + p.NomProduit + "', '" 
                + p.Categorie + "', '" 
                + p.PrixUnitaire + "', '" 
                + p.DateFabrication + "', '" 
                + p.Fournisseur + "', '" 
                + p.AdresseFournisseur + "');";

            if (this.OpenConnexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery();
                this.conn.Close();
            }
        }

        public MySqlDataAdapter ReadProducts()
        {

            string request = "select * from produit";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                mySqlDataAdp = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return mySqlDataAdp;

        }

        

        public bool Auth(string username, string userpassword)
        {
            // définir la requête 
            string request = "SELECT * FROM authuser WHERE username='" + username + "' and userpassword='" + userpassword + "'";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                mySqlDataAdpLogin = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mySqlDataAdpLogin.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    return false;
                }


                this.conn.Close(); // fermer la session de connexion
            }

            return true;

        }

        public void update(Produit p, int ID)
        {
            // définir la requête 
            string request = "UPDATE  produit SET code= '" + p.CodeProduit + "',nomProduit= '" + p.NomProduit + "', categorie= '" + p.Categorie + "', prixUnitaire= '" + p.PrixUnitaire + "', dateFabrication= '" + p.DateFabrication + "', fournisseur = '" + p.Fournisseur + "', addrF = '" + p.AdresseFournisseur + "' WHERE id = " + ID + " ";


            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

        //public MySqlDataReader lireProduits()
        //{
        //try
        //{

        //string sqlCmd = "select * from users order by user_id";
        //string request = "select * from produit";

        //cn.Open(); // have to explicitly open connection (fetches from pool)
        //MySqlDataReader rdr;
        //if (this.OpenConnexion() == true)
        //{
        //MySqlCommand cmd = new MySqlCommand(request, conn);
        //cmd.CommandType = CommandType.Text;
        //rdr = cmd.ExecuteReader();
        //this.conn.Close();

        //} 
        //return rdr;

        //while (rdr.Read())
        //{
        //Console.WriteLine(string.Format("user_id = {0}", rdr["user_id"].ToString()));
        //}
        //}
        //catch (Exception ex)
        //{
        // Console.WriteLine("{oops - {0}", ex.Message);
        //}
        //finally
        //{
        //cn.Dispose(); // return connection to the pool
        //}
        //}



    }
}
