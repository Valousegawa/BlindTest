using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    public class PlayerRomain
    {
        public String pseudo;
        public int idTeam;
        public int score;
        public int highscore;
        public Boolean isArbitre;

        public PlayerRomain()
        {

        }

        public PlayerRomain(String pseudo, int idTeam, int score, int highscore, Boolean isArbitre)
        {
            this.pseudo = pseudo;
            this.idTeam = idTeam;
            this.score = score;
            this.highscore = highscore;
            this.isArbitre = isArbitre;
        }

        public void infosPlayer()
        {
            Console.WriteLine("Pseudo du joueur : " + pseudo);
            Console.WriteLine("Equipe numéro : " + idTeam);
            Console.WriteLine("Score : " + score);
            Console.WriteLine("Meilleur score : " + highscore);
            Console.WriteLine("Est Arbitre : " + isArbitre);
        }
        

        public string Pseudo
        {
            get => pseudo;
            set => pseudo = value;
        }
        public int IdTeam
        {
            get => idTeam;
            set => idTeam = value;
        }

        public int Score
        {
            get => score;
            set => score = value;
        }
        public int Highscore
        {
            get => highscore;
            set => highscore = value;
        }
        public bool IsArbitre
        {
            get => isArbitre;
            set => isArbitre = value;
        }
        
    }
}
