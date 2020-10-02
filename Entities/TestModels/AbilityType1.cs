using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public class AbilityType1
    {        
        public int Id { get; set; }
        public string Type { get; set; }
        public int LvlRequirement { get; set; }
        public int WorldReqKey { get; set; }
        public int WorldReqKeyNavigation { get; set; }
        public int PlayersAbilities { get; set; }
    }
}
