
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Datatypes
{
    public class TeamPlayer
    {
        public int TeamPlayerId { get; set; }
        public string Name { get; set; }

        public int Number { get; set; }

        public string Position { get; set; }

        public bool Active { get; set; }

        public Team Team { get; set; }

    }
}
