using Impact.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Mappings
{
    class MapAbilityType
    {
        public static AbilityType1 Map(AbilityType Orig)
        {
            return new AbilityType1()
            {
                Id = Orig.Id,
                Type = Orig.Type,
                LvlRequirement = (int)Orig.LvlRequirement,
                WorldReqKey = (int)Orig.WorldReqKey
            };
        }

        public static AbilityType Map(AbilityType1 Orig)
        {
            return new AbilityType()
            {
                Id = Orig.Id,
                Type = Orig.Type,
                LvlRequirement = Orig.LvlRequirement,
                WorldReqKey = Orig.WorldReqKey
            };
        }
    }
}
