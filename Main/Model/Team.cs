using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    public class Team
    {
        private int idTeam;
        private String pseudoTeam;
        private int scoreTeam;

        public int IdTeam { get => idTeam; set => idTeam = value; }
        public string PseudoTeam { get => pseudoTeam; set => pseudoTeam = value; }
        public int ScoreTeam { get => scoreTeam; set => scoreTeam = value; }
    }
}
