using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public partial class UserAccounts
    {
        public UserAccounts()
        {
            PlayersAbilities = new HashSet<PlayersAbilities>();
        }

        public int Id { get; set; }
        public int? LocKey { get; set; }
        public int? UserKey { get; set; }
        public long? Credits { get; set; }
        public int? Ptwgold { get; set; }
        public int? LootTableId { get; set; }

        public virtual NodeLocations LocKeyNavigation { get; set; }
        public virtual Users UserKeyNavigation { get; set; }
        public virtual ICollection<PlayersAbilities> PlayersAbilities { get; set; }
    }
}
