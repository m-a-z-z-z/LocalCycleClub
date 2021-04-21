using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCycleClub
{
    class Activities
    {
        string Activity { get; set; }
        string Name { get; set; }
        string Location { get; set; }
        DateTime Date { get; set; }
        string ActivityDescription { get; set; }
        List<string> ResourcesRequired { get; set; }
        public string BadgeEarned { get; set; }

        public Activities(string activity, string Name,string location, DateTime date, string activityDesc, List<string> resourcesReq, string badgeEarned)
        {
            this.Activity = activity;
            this.Name = Name;
            this.Location = location;
            this.Date = date;
            this.ActivityDescription = activityDesc;
            this.ResourcesRequired = resourcesReq;
            this.BadgeEarned = badgeEarned;
        }
    }
}
