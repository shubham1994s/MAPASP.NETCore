using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class Tehsil
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameMar { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? State { get; set; }
        public int? District { get; set; }
        public bool? IsCheked { get; set; }
    }
}
