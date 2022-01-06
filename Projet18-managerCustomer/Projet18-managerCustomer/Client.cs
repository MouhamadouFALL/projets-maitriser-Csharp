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
    }
}
