using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCycleClub
{
    class Activities
    {
        public string ActivityName { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string ActivityDescription { get; set; }
        public List<string> ResourcesRequired { get; set; }
        public string BadgeEarned { get; set; }
    }   
    class achievements
    {
       List<string> Milestones { get; set; }
       DateTime DateAchieved { get; set; }
       int NumOfMilestones{ get; set; }
       string MilestoneDescription { get; set; }
       List<string> AchievableMilestones { get; set; }
       int NumOfTimesEarned { get; set; }
       string MotivationSentence { get; set; }
       DateTime DateStarted { get; set; }


    }

    class members
    {
        string Username {get;set;} 
        string FirstName {get;set;}
        string LastName {get;set;} 
        string Email { get; set; }
        string Password { get; set; }
        DateTime DOB { get; set; }
        string Address { get; set; }
        string CyclingExperience {get;set;} 
    }
}
    
