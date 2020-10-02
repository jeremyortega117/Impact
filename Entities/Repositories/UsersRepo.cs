using Entities.Abstractions;
using Entities.Mappings;
using Impact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (DB.Users.Any(c => c.Email == Users.Email) || Users.Email == null)
            {
                Console.WriteLine($"This Users with email {Users.Email} already exists and cannot be added");
                return;
            }
            else
                DB.Users.Add(Mappings.MapUsers.Map(Users));// this will generate insertMapper.Map(Users)
            DB.SaveChanges();// this will execute the above generate insert query
        }

        public void DeleteUsers(int Id)
        {
            var Cus = DB.Users.FirstOrDefault(Cx => Cx.Id == Id);
            if (Cus.Id == Id)
            {
                DB.Remove(Cus);
                DB.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Cx with id {Id} doesn't exist");
                return;
            }
        }

        public IEnumerable<Users1> ReadInUsers()
        {
            var getCx = from cx in DB.Users
                        select MapUsers.Map(cx);
            return getCx;
        }

        public void UpdateUsers(Users1 Users)
        {
            if (DB.Users.Any(Cx => Cx.Id == Users.Id))
            {
                var user = DB.Users.FirstOrDefault(Cx => Cx.Id == Users.Id);
                user.Fname = Users.Fname;
                user.Lname = Users.Lname;
                user.Phone = Users.Phone;
                user.Email = Users.Email;
                user.Username = Users.Username;
                DB.Users.Update(user);
                DB.SaveChanges();
            }
        }
    }
}
