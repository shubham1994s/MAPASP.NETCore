using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class StateDistrict
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameMar { get; set; }
    }
}
