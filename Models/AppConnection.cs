﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class AppConnection
    {
        public int AppConnectionId { get; set; }
        public int AppId { get; set; }
        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
