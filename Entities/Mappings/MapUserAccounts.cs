using Impact.Models;

namespace Entities.Mappings
{
    class MapUserAccounts
    {
        public static UserAccounts1 Map(UserAccounts Orig)
        {
            return new UserAccounts1()
            {
                Id = Orig.Id,
                LocKey = (int)Orig.LocKey,
                UserKey = (int)Orig.UserKey,
                Credits = (long)Orig.Credits,
                Ptwgold = (int)Orig.Ptwgold,
                LootTableId = (int)Orig.LootTableId
            };
        }

        public static UserAccounts Map(UserAccounts1 Orig)
        {
            return new UserAccounts()
            {
                Id = Orig.Id,
                LocKey = Orig.LocKey,
                UserKey = Orig.UserKey,
                Credits = Orig.Credits,
                Ptwgold = Orig.Ptwgold,
                LootTableId = Orig.LootTableId
            };
        }
    }
}
