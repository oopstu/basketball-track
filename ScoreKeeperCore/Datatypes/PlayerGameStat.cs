using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Datatypes
{
    [DataContract]
    public class PlayerGameStat
    {
        public int PlayerGameStatId { get; set; }

        [DataMember]
        public Team Team
        {
            get; set;
        }

        [DataMember]
        public TeamPlayer Player { get; set; }

        [DataMember]
        public Game Game { get; set; }

        [DataMember]
        public int PlayedMinutes { get; set; }

        [DataMember]
        public int PassesMade { get; set; }

        [DataMember]
        public int ShotsOnGoal { get; set; }

        [DataMember]
        public int GoalsMade { get; set; }

        [DataMember]
        public int SavesMade { get; set; }

        [DataMember]
        public int Steals { get; set; }

        [DataMember]
        public int CommittedTurnOvers { get; set; }

        [DataMember]
        public DateTime GameDate { get; set; }

        [DataMember]
        public int Assists { get; set; }

        [DataMember]
        public int CommittFoul { get; set; }

        [DataMember]
        public int PlayerNumber { get; set; }
        
        [DataMember]
        public int DefensivePressure { get; set; }
        
        [DataMember]
        public int Sportsmanship { get; set; }
        
        [DataMember]
        public int ListenGeneral { get; set; }

        public PlayerGameStat()
        {

        }

        private string GetSummaryString(int shotsMade, int shotsMissed)
        {
            int total = shotsMade + shotsMissed;
            decimal perc = 0;
            if (total > 0)
            {
                perc = 100 * ((decimal)shotsMade / (decimal)total);
            }
            return $"{shotsMade}-{total} ({perc.ToString("F1")}%)";
        }

    }
}
