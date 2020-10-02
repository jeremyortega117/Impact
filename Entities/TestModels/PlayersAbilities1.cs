using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public class PlayersAbilities1
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int AbilityId { get; set; }
        public decimal PlayerAbilityLevel { get; set; }
        public int Ability { get; set; }
        public int Player { get; set; }
    }
}
