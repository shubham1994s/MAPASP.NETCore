using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAPWEBAPP.Models
{

    [Keyless]
    public class SP_MAPS_DETAILS
    {
       
        public string ParentULB { get; set; }
        public Nullable<int> TotalProperty { get; set; }
        public Nullable<int> TotalLiquid { get; set; }
        public Nullable<int> TotalStreet{ get; set; }
        public Nullable<int> TotalDump { get; set; }

        public Nullable<int> TotalProperty_Scan { get; set; }
        public Nullable<int> TotalLiquid_Scan { get; set; }
        public Nullable<int> TotalStreet_Scan { get; set; }
        public Nullable<int> TotalDump_Scan { get; set; }

    }
}
