using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public partial class PlayersAbilities
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public int? AbilityId { get; set; }
        public decimal? PlayerAbilityLevel { get; set; }

        public virtual AbilityType Ability { get; set; }
        public virtual UserAccounts Player { get; set; }
    }
}
