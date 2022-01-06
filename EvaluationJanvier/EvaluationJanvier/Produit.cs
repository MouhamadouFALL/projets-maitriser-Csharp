using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationJanvier
{
    internal class Produit
    {

        // Les champs 
        private int code;
        private string nomProduit;
        private string categorie;
        private double prixUnitaire;
        private string dateFabrication;
        private string fournisseur;
        private string adresseFournisseur;

        public Produit() { }

        public string AdresseFournisseur { get { return adresseFournisseur; } set { adresseFournisseur = value; } }
        public string Fournisseur { get { return fournisseur; } set { fournisseur = value; } }
        public string DateFabrication { get { return dateFabrication; } set { dateFabrication = value; } }
        public double PrixUnitaire { get { return prixUnitaire; } set { prixUnitaire = value; } }
        public string Categorie { get { return categorie; } set { categorie = value; } }
        public string NomProduit { get { return nomProduit; } set { nomProduit = value; } }
        public int Code { get { return code; } set { code = value; } }
    }

}
