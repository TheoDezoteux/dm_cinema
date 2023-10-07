using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Film
    {
        private int annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public Film(int annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = acteurPrincipal;
        }

        public int getAnnee
        {
            get { return annee; }
            set { annee = value; }
        }

        public string getGenre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int getIdFilm
        {
            get { return idFilm; }
            set { idFilm = value; }
        }

        public static Film getInstance(int annee, string genre, int idFIlm, string resume, string titre, Acteur acteurPrincipal)
        {
            return new Film(annee, genre, idFIlm, resume, titre, acteurPrincipal);
        }

        public string getResume
        {
            get { return resume; }
            set { resume = value; }
        }

        public string getTitre
        {
            get { return titre; }
            set { titre = value; }
        }
        public Acteur getActeurPrincipal()
        {
            return acteurPrincipal;
        }

        public override string ToString()
        {
            return $"Titre : {getTitre}\nAnnée : {getAnnee}\nGenre : {getGenre}\nRésumé : {getResume}";
        }
    }
}
