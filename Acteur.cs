using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Acteur
    {
        private DateOnly anneeNaissance;
        private int id;
        private string nom;
        private string prenom;
        private int idActeur; 
        
        public Acteur(DateOnly anneeNaissance, int id, string nom, string prenom)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Acteur(int idActeur, string nom, string prenom)
        {
            this.idActeur = idActeur;
            this.nom = nom;
            this.prenom = prenom;
        }

        public DateOnly getAnneeNaissance
        {
            get { return anneeNaissance; }
            set { anneeNaissance = value; }
        }

        public int getId
        {
            get { return id; }
            set { id = value; }
        }

        public static Acteur getInstance(DateOnly anneeNaissance, int id, string nom, string prenom)
        {
            return new Acteur(anneeNaissance, id, nom, prenom);
        }

        public string getNom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string getPrenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public override string ToString()
        {
            return $"Nom : {getNom} Prénom : {getPrenom} Année de naissance : {getAnneeNaissance}";
        }


    }
}
