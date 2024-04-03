using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC1_Olivella_Arnau
{
    public class Score
    {
        public string Player { get; set; }
        public string Mission { get; set; }
        public int Scoring { get; set; }

        public Score(string player, string mission, int scoring)
        {
            Player = player;
            Mission = mission;
            Scoring = scoring;
        }
    }
}
