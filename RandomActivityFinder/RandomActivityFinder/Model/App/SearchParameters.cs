using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomActivityFinder.Core.Model.App
{
    public class SearchParameters
    {
        public double ActivityDistance { get; set; }
        public int ActivityType { get; set; }
        public string ActivityCustomSearch { get; set; }

        public double UserLatitude { get; set; } 

        public double UserLongitude { get; set; }
    }
}
