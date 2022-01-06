using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet18_managerCustomer
{
    internal class Customer
    {
        private int code;
        private string nom;
        private string prenom;
        private int solde;
        private string naissance;
        private string nationatile;
        private string niveau;

        // Constructeur
        public Customer() {} // Sans Argument


        
        //////////////////////////////////////////     Getter qnd Setters      /////////////////////////////////////
        public int Id
        { 
            get { return code; } 
            set { code = value; } 
        }

        public string Nom
        { get { return nom; } set { nom = value; } }

        public string Prenom
        { get { return prenom; } set { prenom = value; } }

        public int Solde
        { get { return solde; } set { solde = value; } }

        public string Naissance
        { get { return naissance; } set { naissance = value; } }

        public string Nationatile
        { get { return nationatile; } set { nationatile = value; } }

        public string Niveau
        { get { return niveau; } set { niveau = value; } }



    }
}
