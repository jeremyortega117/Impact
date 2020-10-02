using Entities.Abstractions;
using Impact.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    class UsersRepo : IUsers<Users1>
    {
        Game_ImpactContext DB;
        public UsersRepo()
        {
            DB = new Game_ImpactContext();
        }
        public UsersRepo(Game_ImpactContext DB)
        {
            this.DB = DB ?? throw new ArgumentNullException(nameof(DB));

        }

        public void CreateUsers(Users1 Users)
        {
            throw new NotImplementedException();
        }

        public void DeleteUsers(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users1> ReadInUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUsers(Users1 Users)
        {
            throw new NotImplementedException();
        }
    }
}
