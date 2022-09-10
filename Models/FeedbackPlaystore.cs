using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class FeedbackPlaystore
    {
        public int PlaystoreId { get; set; }
        public int? AppId { get; set; }
        public string Ulblink { get; set; }
    }
}
