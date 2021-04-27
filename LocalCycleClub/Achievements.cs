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
        DateTime DateAcheived { get; set; }
        int NumOfMilestone { get; set; }
        string MilestoneDescription { get; set; }
        List<string> AchievableMilestone { get; set; }
        int ClubRank { get; set; }
        string MotivationSentence { get; set; }
        DateTime DateStarted { get; set; }

        public Achievements(List<string> milestone, DateTime dateAchieved, int numMilestones, string milestoneDesc,
            List<string> achievableMs, int clubRank, string motivation, DateTime dateStarted)
        {
            this.Milestones = milestone;
            this.DateAcheived = dateAchieved;
            this.NumOfMilestone = numMilestones;
            this.MilestoneDescription = milestoneDesc;
            this.AchievableMilestone = achievableMs;
            this.ClubRank = clubRank;
            this.MotivationSentence = motivation;
            this.DateStarted = dateStarted;
        }

    }
}
