using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Datatypes
{
    public class Game
    {
        public int GameId { get; set; }

        public Team Team { get; set; }

        public string Location { get; set; }

        public string FinalScore { get; set; }

        public DateTime GameDateTime { get; set; }

        public bool HomeGame { get; set; }

        public GameOutcome Outcome { get; set; }

        public string OpposingTeamNameOrId { get; set; }

        public string GetGameDate() {
            return GameDateTime.ToString("dd MMMM, yyyy");
        }
    }

    public enum GameOutcome { 
        Win,
        Loss,
        Tie
    }
}
