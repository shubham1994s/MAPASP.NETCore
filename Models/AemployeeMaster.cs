﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MAPWEBAPP.Models
{
    public partial class AemployeeMaster
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpNameMar { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public string EmpMobileNumber { get; set; }
        public string EmpAddress { get; set; }
        public string Type { get; set; }
        public bool? IsActive { get; set; }
        public int? StateId { get; set; }
        public int? DivisionId { get; set; }
        public int? DistictId { get; set; }
        public string IsActiveUlb { get; set; }
        public DateTime? LastModifyDateEntry { get; set; }
    }
}
