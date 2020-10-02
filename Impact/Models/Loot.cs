﻿using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public partial class Loot
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? BaseDamage { get; set; }
        public decimal? BaseWeight { get; set; }
        public int? WorldReqKey { get; set; }

        public virtual WorldRequirements WorldReqKeyNavigation { get; set; }
    }
}
