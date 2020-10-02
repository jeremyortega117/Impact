using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public partial class UserAccounts1
    {
        public int Id { get; set; }
        public int LocKey { get; set; }
        public int UserKey { get; set; }
        public long Credits { get; set; }
        public int Ptwgold { get; set; }
        public int LootTableId { get; set; }
        public int LocKeyNavigation { get; set; }
        public int UserKeyNavigation { get; set; }
        public int PlayersAbilities { get; set; }
    }
}
