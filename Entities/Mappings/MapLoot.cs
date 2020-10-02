using Impact.Models;

namespace Entities.Mappings
{
    class MapLoot
    {
        public static Loot1 Map(Loot Orig)
        {
            return new Loot1()
            {
                Id = Orig.Id,
                Type = Orig.Type,
                BasePrice = (decimal)Orig.BasePrice,
                BaseDamage = (decimal)Orig.BaseDamage,
                WorldReqKey = (int)Orig.WorldReqKey
            };
        }

        public static Loot Map(Loot1 Orig)
        {
            return new Loot()
            {
                Id = Orig.Id,
                Type = Orig.Type,
                BasePrice = Orig.BasePrice,
                BaseDamage = Orig.BaseDamage,
                WorldReqKey = Orig.WorldReqKey
            };
        }
    }
}
