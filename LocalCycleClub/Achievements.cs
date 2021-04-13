using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCycleClub
{
    class Achievements
    {
        List<string> Milestones { get; set; }
        DateTime DateAchieved { get; set; }
        int NumOfMilestones { get; set; }
        string MilestoneDescription { get; set; }
        List<string> AchievableMilestones { get; set; }
        int NumOfTimesEarned { get; set; }
        string MotivationSentence { get; set; }
        DateTime DateStarted { get; set; }

        public Achievements(List<string> milestone, DateTime dateAchieved, int numMilestones, string milestoneDesc, List<string> achievableMs, int numTimesEarned, string motivation, DateTime dateStarted)
        {
            this.Milestones = new List<string>();
            this.DateAchieved = dateAchieved;
            this.NumOfMilestones = numMilestones;
            this.MilestoneDescription = milestoneDesc;
            this.AchievableMilestones = new List<string>();
            this.NumOfTimesEarned = numTimesEarned;
            this.MotivationSentence = motivation;
            this.DateStarted = dateStarted;

        }
    }
}
