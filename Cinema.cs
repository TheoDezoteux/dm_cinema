using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Cinema
    {
        private Cinema cine;
        private List<Acteur> lesActeurs;
        private List<Film> lesFilms;

        public Cinema()
        {
            lesActeurs = new List<Acteur>();
            lesFilms = new List<Film>();
        }

        public static Cinema getInstance()
        {
            return new Cinema();
        }

        public Acteur getActeur(int idActeur)
        {
            return lesActeurs.Find(acteur => acteur.getId == idActeur);
        }

        public Film getFilm(int idFilm)
        {
            return lesFilms.Find(film => film.getIdFilm == idFilm);
        }

        public int nbActeur()
        {
            return lesActeurs.Count;
        }
        
        public int nbFilm()
        { 
            return lesFilms.Count; 
        }
        public void setFilm(int annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            Film nouveauFilm = new Film(annee, genre, idFilm, resume, titre, acteurPrincipal);
            lesFilms.Add(nouveauFilm);
        }

        public void setActeur(int idActeur, string nom, string prenom)
        {
            Acteur nouvelActeur = new Acteur(idActeur, nom, prenom); ;
            lesActeurs.Add(nouvelActeur);
        }
    }
}
