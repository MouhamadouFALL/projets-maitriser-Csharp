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

        private string nomUser;
        private string nomPassword;
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
            nomUser = "root";
            nomPassword = "";
            dbName = "client_ms";
            server = "localhost";
            string connexion = "SERVER=" + server + ";" 
                + "DATABASE=" + dbName + ";" 
                + "UID=" + nomUser + ";" 
                + "PASSWORD=" + nomPassword + ";";

            conn = new MySqlConnection(connexion);
        }

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
                    case 0: MessageBox.Show("Problemede connnexion");
                        break;
                    case 1045: MessageBox.Show("Login ou Mot de pass incorrecte");
                        break;
                }

                return false;
            }
        }

        public void Insert(int code, string nom, string prenom, int solde, string naissance, string nationalite, string niveau)
        {
            string request = "INSERT INTO customers(code, nom, prenom, solde, naissance, nationalite, niveau)" 
                + " VALUES("+code+", '"+ nom + "', '" + prenom + "', '" + solde + "', '" + naissance + "', '" + nationalite + "', '" + niveau + "')";

            if (this.OpenConnexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery();
                this.conn.Close();
            }
        }

    }
}
