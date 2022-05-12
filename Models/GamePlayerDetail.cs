using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class GamePlayerDetail
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public int? GameId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int? Score { get; set; }
        public string DeviceId { get; set; }
        public DateTime? Created { get; set; }
    }
}
