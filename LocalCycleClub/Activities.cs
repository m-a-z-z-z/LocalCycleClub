using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCycleClub
{
    class Activities
    {
        string ActivityName { get; set; }
        string Location { get; set; }
        DateTime Date { get; set; }
        string ActivityDescription { get; set; }
        List<string> ResourcesRequired { get; set; }
        public string BadgeEarned { get; set; }

        public Activities(string activityName,string location, DateTime date, string activityDesc, List<string> resourcesReq, string badgeEarned)
        {
            this.ActivityName = activityName;
            this.Location = location;
            this.Date = date;
            this.ActivityDescription = activityDesc;
            this.ResourcesRequired = resourcesReq;
            this.BadgeEarned = badgeEarned;
        }
    }
}
