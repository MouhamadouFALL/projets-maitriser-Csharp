using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace EvaluationBD
{
    internal class DBConnect
    {
        private string user;
        private string password;
        private string dbName;
        private string server;
        private MySqlConnection conn;

        MySqlDataAdapter adpt;
        MySqlDataAdapter adptLogin;

        public DBConnect()
        {
            initilize();
        }

        // Créer la connexion à la base de données
        private void initilize()
        {
            user = "root";
            password = "";
            dbName = "bdevaluationcsharp";
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

        public void Insert(Etudiant e)
        {
            // définir la requête 
            string request = "INSERT INTO etudiant(matricule, nom, prenom, classe, niveau, fliere, datenaissance, adresse, nationalite)"
                + " VALUES('" + e.Matricule + "', '" + e.Nom + "', '" + e.Prenom + "', '" + e.Classe + "', '" + e.Niveau + "', '" + e.Fliere + "', '" + e.DateNaissance + "', '" +e.Adresse+ "', '" +e.Nationalite+ "');";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }
        }

        public MySqlDataAdapter ReadAll()
        {

            string request = "select * from etudiant";
            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                adpt = new MySqlDataAdapter(request, conn);

                this.conn.Close(); // fermer la session de connexion
            }
            return adpt;
        }
        
        public void Update(Etudiant e, int id)
        {
            // définir la requête 
            string request = "UPDATE  etudiant SET matricule= '" + e.Matricule + "',nom= '" + e.Nom + "', prenom= '" + e.Prenom + "', classe= '" + e.Classe + "', niveau= '" + e.Niveau + "', fliere = '" + e.Fliere + "', datenaissance = '" + e.DateNaissance + "', adresse= '" + e.Adresse + "', nationalite= '" + e.Nationalite +"' WHERE id = " + id + " ";


            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

        }

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

        public void Delete(int ID)
        {
            // définir la requête 
            string request = "DELETE FROM etudiant WHERE id = " + ID + " ";

            if (this.OpenConnexion() == true) // vérifier si la connexion à été ouvert
            {
                MySqlCommand cmd = new MySqlCommand(request, conn);
                cmd.ExecuteNonQuery(); // Exécter la requpete
                this.conn.Close(); // fermer la session de connexion
            }

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
