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

namespace EvaluationBD
{
    public partial class Student : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;

        int id;
        public Student()
        {
            InitializeComponent();
            dispay();
        }

        private void labelSaved_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // recupérer les saisies et les mettre dans l'objet Produit
            Etudiant etu = new Etudiant();

            etu.Matricule = matricule.Text.Trim();
            etu.Nom = nom.Text.Trim();
            etu.Prenom = prenom.Text.Trim();
            etu.Classe = classe.Text.Trim();
            etu.Niveau = niveau.Text.Trim();
            etu.Fliere = fliere.Text.Trim();
            etu.DateNaissance = dateNaissance.Text.Trim();
            etu.Adresse = adresse.Text.Trim();
            etu.Nationalite = nationalite.Text.Trim();

            // Inserer les données dans la base de données dbproduits
            DBConnect dBConnect = new DBConnect();
            dBConnect.Insert(etu);

            clear();
            dispay();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dispay();
        }

        public void dispay()
        {
            DBConnect dBConnect = new DBConnect();

            adpt = new MySqlDataAdapter();
            dt = new DataTable();
            adpt = dBConnect.ReadAll();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void clear()
        {
            matricule.Text = null;
            nom.Text = null;
            prenom.Text = null;
            classe.Text = null;
            niveau.Text = null;
            fliere.Text = null;
            dateNaissance.Text = null;
            adresse.Text = null;
            nationalite.Text=null;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (matricule.Text == "" || nom.Text == "" || prenom.Text == "" || classe.Text == "" || niveau.Text == "" || fliere.Text == "" || dateNaissance.Text == "")
            {
                MessageBox.Show(" Please Fill in the Blanks");

            }
            else
            {
                Etudiant etu = new Etudiant();

                etu.Matricule = matricule.Text.Trim();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            matricule.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            prenom.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            classe.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            niveau.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            fliere.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateNaissance.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            adresse.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            nationalite.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (matricule.Text == "" || nom.Text == "" || prenom.Text == "" || classe.Text == "" || niveau.Text == "" || fliere.Text == "" || dateNaissance.Text == "")
            {
                MessageBox.Show(" Please Fill in the Blanks");

            }
            else
            {
                
                DBConnect dbconnect = new DBConnect();
                dbconnect.Delete(id);

                MessageBox.Show(" Delete bien Passer ");
                clear();
                dispay();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
