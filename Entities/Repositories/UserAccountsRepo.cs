using Entities.Abstractions;
using Impact.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    class UserAccountsRepo : IUserAccounts<UserAccounts1>
    {
        Game_ImpactContext DB;
        public UserAccountsRepo()
        {
            DB = new Game_ImpactContext();
        }
        public UserAccountsRepo(Game_ImpactContext DB)
        {
            this.DB = DB ?? throw new ArgumentNullException(nameof(DB));

        }

        public void CreateUserAccounts(UserAccounts1 UserAccounts)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserAccounts(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserAccounts1> ReadInUserAccounts()
        {
            throw new NotImplementedException();
        }

        public void UpdateUserAccounts(UserAccounts1 UserAccounts)
        {
            throw new NotImplementedException();
        }
    }
}
