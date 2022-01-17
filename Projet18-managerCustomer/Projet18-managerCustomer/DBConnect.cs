using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projet18_managerCustomer
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
            dbName = "client_ms";
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

            }catch (MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0: MessageBox.Show("Problème de connnexion !!");
                        break;
                    case 1045: MessageBox.Show("Login ou Mot de pass incorrecte !");
                        break;
                }

                return false;
            }
        }

        public void Insert(Customer c)
        {
            // définir la requête 
            string request = "INSERT INTO customers(code, nom, prenom, solde, naissance, nationalite, niveau)" 
                + " VALUES("+c.Id+", '"+ c.Nom + "', '" + c.Prenom + "', '" + c.Solde + "', '" + c.Naissance + "', '" + c.Nationatile + "', '" + c.Niveau + "')";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }

        /*public void Insert1(int code, string nom, string prenom, int solde, string naissance, string nationalite, string niveau)
        {
            // définir la requête 
            string request = "INSERT INTO customers(code, nom, prenom, solde, naissance, nationalite, niveau)"
                + " VALUES(" + code + ", '" + nom + "', '" + prenom + "', '" + solde + "', '" + naissance + "', '" + nationalite + "', '" + niveau + "')";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }*/

    }
}
