using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationBD
{
    internal class Etudiant
    {
        private string matricule;
        private string nom;
        private string prenom;
        private string classe;
        private string niveau;
        private string fliere;
        private string dateNaissance;
        private string adresse;
        private string nationalite;

        public Etudiant() { }

        public string Matricule
        {
            get { return matricule; } set { matricule = value; } 
        }

        public string Nom
        {
            get { return nom; } set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; } set { prenom = value; }
        }

        public string Classe
        {
            get { return classe; } set { classe = value; }
        }

        public string Niveau
        {
            get { return niveau; } set { niveau = value; }
        }

        public string Fliere
        {
            get { return fliere; } set { fliere = value; }
        }

        public string DateNaissance
        {
            get { return dateNaissance; } set { dateNaissance = value; }
        }

        public string Adresse
        {
            get { return adresse; } set { adresse = value; }
        }

        public string Nationalite
        {
            get { return nationalite; }
            set { nationalite = value; }
        }

    }
}
