using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class CountryState
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string StateNameMar { get; set; }
        public string State3Code { get; set; }
        public string State2Code { get; set; }
    }
}
