﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAPWEBAPP.Models
{
    [Keyless]
    public class SP_ULBADMINMAP
    {
        public Nullable<int> ULBId { get; set; } = 0;
        public string ULBName { get; set; } = "";
        public string ParentULB { get; set; } = "";
        public Nullable<int> TotalHouse { get; set; } = 0;
        public Nullable<int> TotalHouseScan { get; set; } = 0;
        public Nullable<int> TotalLiquid { get; set; } = 0;
        public Nullable<int> TotalLiquidScan { get; set; } = 0;
        public Nullable<int> TotalStreet { get; set; } = 0;
        public Nullable<int> TotalStreetScan { get; set; } = 0;
        public Nullable<int> TotalDump { get; set; } = 0;
        public Nullable<int> TotalDumpScan { get; set; } = 0;

    }
}
