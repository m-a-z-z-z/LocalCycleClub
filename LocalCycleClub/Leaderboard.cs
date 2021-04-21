using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalCycleClub
{
    class Leaderboard
    {
    
        string name { get; set; }
        int cyclesTaken { get; set; }
        double DistanceCycled { get; set; }

        public Leaderboard (string name, int cyclesTaken, double DistanceCycled)
        {
            this.name = name;
            this.cyclesTaken = cyclesTaken;
            this.DistanceCycled = DistanceCycled;
        }

    }

  
}
