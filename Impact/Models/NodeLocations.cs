using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public partial class NodeLocations
    {
        public NodeLocations()
        {
            UserAccounts = new HashSet<UserAccounts>();
        }

        public int Id { get; set; }
        public decimal? X { get; set; }
        public decimal? Y { get; set; }
        public decimal? Z { get; set; }

        public virtual ICollection<UserAccounts> UserAccounts { get; set; }
    }
}
