using Impact.Models;


namespace Entities.Mappings
{
    public class MapUsers
    {
        public static Users1 Map(Users Orig)
        {
            return new Users1()
            {
                Id = Orig.Id,
                Fname = Orig.Fname,
                Lname = Orig.Lname,
                Email = Orig.Email,
                Phone = Orig.Phone,
                Username = Orig.Username
            };
        }

        public static Users Map(Users1 Orig)
        {
            return new Users()
            {
                Id = Orig.Id,
                Fname = Orig.Fname,
                Lname = Orig.Lname,
                Email = Orig.Email,
                Phone = Orig.Phone,
                Username = Orig.Username
            };
        }
    }
}
