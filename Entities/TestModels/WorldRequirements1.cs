using System;
using System.Collections.Generic;

namespace Impact.Models
{
    public partial class WorldRequirements1
    {     
        public int Id { get; set; }
        public byte IntMinLvl { get; set; }
        public byte StrMinLvl { get; set; }
        public byte DexMinLvl { get; set; }
        public byte DarkMinLvl { get; set; }
        public byte LightMinLvl { get; set; }
        public byte EarthMinLvl { get; set; }
        public byte FireMinLvl { get; set; }
        public byte WindMinLvl { get; set; }
        public byte WaterMinLvl { get; set; }
        public int AbilityType { get; set; }
        public int Loot { get; set; }
    }
}
