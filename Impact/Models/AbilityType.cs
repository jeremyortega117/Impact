using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public partial class AbilityType
    {
        public AbilityType()
        {
            PlayersAbilities = new HashSet<PlayersAbilities>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public int? LvlRequirement { get; set; }
        public int? WorldReqKey { get; set; }

        public virtual WorldRequirements WorldReqKeyNavigation { get; set; }
        public virtual ICollection<PlayersAbilities> PlayersAbilities { get; set; }
    }
}
