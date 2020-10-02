using Impact.Models;

namespace Entities.Mappings
{
    class MapWorldRequirements
    {
        public static WorldRequirements1 Map(WorldRequirements Orig)
        {
            return new WorldRequirements1()
            {
                Id = Orig.Id,
                IntMinLvl = (byte)Orig.IntMinLvl,
                StrMinLvl = (byte)Orig.StrMinLvl,
                DexMinLvl = (byte)Orig.DexMinLvl,
                DarkMinLvl = (byte)Orig.DarkMinLvl,
                LightMinLvl = (byte)Orig.LightMinLvl,
                EarthMinLvl = (byte)Orig.EarthMinLvl,
                FireMinLvl = (byte)Orig.FireMinLvl,
                WindMinLvl = (byte)Orig.WindMinLvl,
                WaterMinLvl = (byte)Orig.WaterMinLvl
            };
        }

        public static WorldRequirements Map(WorldRequirements1 Orig)
        {
            return new WorldRequirements()
            {
                Id = Orig.Id,
                IntMinLvl = Orig.IntMinLvl,
                StrMinLvl = Orig.StrMinLvl,
                DexMinLvl = Orig.DexMinLvl,
                DarkMinLvl = Orig.DarkMinLvl,
                LightMinLvl = Orig.LightMinLvl,
                EarthMinLvl = Orig.EarthMinLvl,
                FireMinLvl = Orig.FireMinLvl,
                WindMinLvl = Orig.WindMinLvl,
                WaterMinLvl = Orig.WaterMinLvl
            };
        }
    }
}
