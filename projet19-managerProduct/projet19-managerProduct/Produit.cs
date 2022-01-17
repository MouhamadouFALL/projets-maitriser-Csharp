using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet19_managerProduct
{
    internal class Produit
    {
        // les attributs
        private string codeProduit;
        private string nomProduit;
        private string categorie;
        private double prixUnitaire;
        private string dateFabrication;
        private string fournisseur;
        private string adresseFournisseur;

        // Constructeur
        public Produit() { }

        ///////////////////////////////////// GETTERS AND SETTERS ////////////////////////////////
        public string AdresseFournisseur { get { return adresseFournisseur;} set { adresseFournisseur = value; } }
        public string Fournisseur { get { return fournisseur; } set { fournisseur = value; } }
        public string DateFabrication { get { return dateFabrication; } set { dateFabrication = value; } }
        public double PrixUnitaire { get { return prixUnitaire; } set { prixUnitaire = value; } }
        public string Categorie { get { return categorie; } set { categorie = value; } }
        public string NomProduit { get { return nomProduit; } set { nomProduit = value; } }
        public string CodeProduit { get { return codeProduit; } set { codeProduit = value; } }
    }
}
