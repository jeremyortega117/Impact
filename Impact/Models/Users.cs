using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public partial class Users
    {
        public Users()
        {
            UserAccounts = new HashSet<UserAccounts>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }

        public virtual ICollection<UserAccounts> UserAccounts { get; set; }
    }
}
