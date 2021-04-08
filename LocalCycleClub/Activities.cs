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
}
