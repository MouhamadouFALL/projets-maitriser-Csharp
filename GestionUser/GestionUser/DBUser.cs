using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GestionUser
{
    internal class DBUser
    {
        private string user;
        private string password;
        private string dbName;
        private string server;
        private MySqlConnection conn;

        MySqlDataAdapter adpt;
        MySqlDataAdapter adptLogin;

        public DBUser()
        {
            initilize();
        }

        // Créer la connexion à la base de données
        private void initilize()
        {
            user = "root";
            password = "";
            dbName = "bduser";
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

        public void Insert(Utilisateur u)
        {
            // définir la requête
            string request = "INSERT INTO user(login, password) "
                + " VALUES('" + u.Login + "', '" + u.Password + "');";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }

        
        public MySqlDataAdapter ReadAll()
        {

            string request = "select * from user";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }
        
        public void Update(Utilisateur u, int id)
        {
            // définir la requête 
            string request = "update  user set login = '" + u.Login + "',password = '" + u.Password + "' where id = " + id + " ";


            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

        public void Delete(int ID)
        {
            // définir la requête 
            string request = "delete from user where id = " + ID + " ";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

        /*
        public bool Auth(string username, string userpassword)
        {
            // définir la requête 
            string request = "SELECT * FROM user WHERE login='" + username + "' and password='" + userpassword + "'";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                adptLogin = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adptLogin.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    return false;
                }


                this.conn.Close(); // fermer la session de connexion
            }

            return true;

        }

        


        /*
        public bool Login(string Username, string PassWord)
        {
            // définir la requête 
            string request = "SELECT * FROM loginusers WHERE U_Name='" + Username + "' and U_Pass='" + PassWord + "'";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                adptLogin = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adptLogin.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    return false;
                }


                this.conn.Close(); // fermer la session de connexion
            }

            return true;

        }*/
    }
}
