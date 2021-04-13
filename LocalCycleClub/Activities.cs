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

        public Activities(string activityName, string name, string location, DateTime date, string activityDesc, List<string> resourcesReq, string badgeEarned)
        {
            this.ActivityName = activityName;
            this.Name = name;
            this.Location = location;
            this.Date = date;
            this.ActivityDescription = activityDesc;
            this.ResourcesRequired = new List<string>();
            this.BadgeEarned = badgeEarned;
        }
    }
}
