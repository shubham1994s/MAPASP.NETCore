using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class UserInApp
    {
        public int UserInAppsId { get; set; }
        public string UserId { get; set; }
        public int AppId { get; set; }
        public int SubscriptionId { get; set; }
    }
}
