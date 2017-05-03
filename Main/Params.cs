using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Params
    {
        List<String> joueurs;
        List<String> genres;
        int nbr_chansons;

        public Params()
        {
            this.Nbr_chansons = 10;
        }

        public Params(List<String> joueurs, List<String> genres, int nbr_chansons)
        {
            this.Joueurs = joueurs;
            this.Genres = genres;
            this.Nbr_chansons = nbr_chansons;
        }

        public List<string> Joueurs { get => joueurs; set => joueurs = value; }
        public List<string> Genres { get => genres; set => genres = value; }
        public int Nbr_chansons { get => nbr_chansons; set => nbr_chansons = value; }
    }
}
