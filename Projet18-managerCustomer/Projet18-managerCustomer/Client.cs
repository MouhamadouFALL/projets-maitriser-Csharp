using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet18_managerCustomer
{
    public partial class Client : Form
    {

        public Client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Customer client = new Customer();

            client.Id = int.Parse(id.Text);
            client.Nom = nom.Text;
            client.Prenom = prenom.Text;
            client.Solde = int.Parse(solde.Text);
            client.Naissance = naissance.Text;
            client.Nationatile = nationalite.Text;
            client.Niveau = niveau.Text;

            rid.Text = client.Id.ToString();
            rnom.Text = client.Nom;
            rprenom.Text = client.Prenom;
            rsolde.Text = client.Solde.ToString();
            rnaissance.Text = client.Naissance;
            rnationalite.Text = client.Nationatile;
            rniveau.Text = client.Niveau;

            DBConnect dBConnect = new DBConnect();
            dBConnect.Insert(client.Id, client.Nom, client.Prenom, client.Solde, client.Naissance, client.Nationatile, client.Niveau);
        }

        private void Clean()
        {
            id.Text = null;
            nom.Text = null;
            prenom.Text = null;
            solde.Text = null;
            naissance.Text = null;
            nationalite.Text = null;
            niveau.Text = null;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Clean();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            rid.Text = null;
            //rid.Visible = false;
            rnom.Text = null;
            //rnom.Visible = false;
            rprenom.Text = null;
            //rprenom.Visible = false;
            rsolde.Text = null;
            //rsolde.Visible = false;
            rnaissance.Text = null;
            //rnaissance.Visible = false;
            rnationalite.Text = null;
            //rnationalite.Visible = false;
            rniveau.Text = null;
            //rniveau.Visible = false;
        }
    }
}
