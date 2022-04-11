using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    public class Save
    {
        public int Points { get; set; }
        public int PointsPerClick { get; set; }
        public int PointsPerSecond { get; set; }
        public bool UpgrSuit { get; set; }
        public bool UpgrWheels { get; set; }
        public bool UpgrSteeringWheel { get; set; }
        public bool UpgrCommunications { get; set; }
        public bool UpgrTools { get; set; }
        public bool UpgrTeammate { get; set; }
    }
}
