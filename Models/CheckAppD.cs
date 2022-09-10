using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class CheckAppD
    {
        public int Id { get; set; }
        public string AppName { get; set; }
        public bool IsCheked { get; set; }
        public int? AppId { get; set; }
        public bool? IsActive { get; set; }
    }
}
