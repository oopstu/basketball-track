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
        public int InsideShotsMissed { get; set; }

        [DataMember]
        public int InsideShotsMade { get; set; }

        [DataMember]
        public int FGMissed { get; set; }

        [DataMember]
        public int FGMade { get; set; }

        [DataMember]
        public int Blocks { get; set; }

        [DataMember]
        public int Steals { get; set; }

        [DataMember]
        public int CommittedTurnOvers { get; set; }

        [DataMember]
        public DateTime GameDate { get; set; }

        [DataMember]
        public int Assists { get; set; }

        [DataMember]
        public int Rebounds { get; set; }

        [DataMember]
        public int ThreeMissed { get; set; }

        [DataMember]
        public int ThreeMade { get; set; }

        [DataMember]
        public int MissedFoulShots { get; set; }

        [DataMember]
        public int MadeFoulShots { get; set; }

        [DataMember]
        public int CommittFoul { get; set; }

        [DataMember]
        public int PlayerNumber { get; set; }

        public PlayerGameStat()
        {

        }

        // Summary Stuff
        public string GetInsideSummary()
        {

            return GetSummaryString(InsideShotsMade, InsideShotsMissed);
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

        public string GetFieldGoalSummary()
        {

            return GetSummaryString(FGMade, FGMissed);

        }
        public string GetFoulSummary()
        {
            return GetSummaryString(MadeFoulShots, MissedFoulShots);
        }
    }
}
