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

namespace GestionUser
{
    public partial class User : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;

        int id;
        public User()
        {
            InitializeComponent();
            dispay();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || password.Text == "")
            {
                MessageBox.Show(" Please Entrer votre login et votre mot de pass ");
            }
            else
            {
                Utilisateur u = new Utilisateur();
                u.Login = login.Text;
                u.Password = password.Text;
                //Insert 
                DBUser dbuser = new DBUser();
                dbuser.Insert(u);

                MessageBox.Show("user added");

                clear();
                dispay();



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            login.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            password.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            login.Text = null;
            password.Text = null;
        }

        public void dispay()
        {
            DBUser dBuser = new DBUser();

            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            adpt = dBuser.ReadAll();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || password.Text == "")
            {
                MessageBox.Show(" Please Fill in the Blanks");

            }
            else
            {
                Utilisateur u = new Utilisateur();

                u.Login = login.Text.Trim();
                u.Password = password.Text.Trim();
                

                // Inserer à la base
                DBUser dbuser = new DBUser();
                dbuser.Update(u, id);

                MessageBox.Show(" Modifier etudiant ok");
                clear();
                dispay();
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill in the blanks");
            }else
            {
                DBUser dbuser = new DBUser();
                dbuser.Delete(id);

                MessageBox.Show("user has been successfully deleted");
                clear();
                dispay();
            }
        }
    }
}
