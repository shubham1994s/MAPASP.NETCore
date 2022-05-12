using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class BinMaster
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public int? AppId { get; set; }
        public string AppName { get; set; }
    }
}
