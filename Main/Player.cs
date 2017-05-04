using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Player
    {
        String pseudo;
        int is_arbitre;
        int id_team;
        int score;
        int high_score;

        public Player()
        {
            this.Is_arbitre = 0;
            this.Id_team = 0;
            this.Score = 0;
        }

        public Player(String pseudo, int is_arbitre, int id_team, int score)
        {
            this.Pseudo = pseudo;
            this.Is_arbitre = is_arbitre;
            this.Id_team = id_team;
            this.Score = score;
            this.High_score = 0;
        }

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public int Is_arbitre { get => is_arbitre; set => is_arbitre = value; }
        public int Id_team { get => id_team; set => id_team = value; }
        public int Score { get => score; set => score = value; }
        public int High_score { get => high_score; set => high_score = value; }
    }
}
