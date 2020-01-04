using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Datatypes
{
    [DataContract]
    public class PlayerStat
    {
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
        public int PlayerNumber { get; set; }

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
        public string Name { get; set; }

        [DataMember]
        public int MissedFoulShots { get; set; }

        [DataMember]
        public int MadeFoulShots { get; set; }

        [DataMember]
        public int CommittFoul { get; set; }

        public PlayerStat(int num, string name)
        {
            PlayerNumber = num;
            Name = name;
        }

        public PlayerStat()
        {

        }
    }
}
