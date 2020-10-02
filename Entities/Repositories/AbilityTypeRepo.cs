using Entities.Abstractions;
using Impact.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    class AbilityTypeRepo : IAbilityType<AbilityType1>
    {
        Game_ImpactContext DB;
        public AbilityTypeRepo()
        {
            DB = new Game_ImpactContext();
        }
        public AbilityTypeRepo(Game_ImpactContext DB)
        {
            this.DB = DB ?? throw new ArgumentNullException(nameof(DB));

        }

        public void CreateAbilityType(AbilityType1 AbilityType)
        {
            throw new NotImplementedException();
        }

        public void DeleteAbilityType(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AbilityType1> ReadInAbilityType()
        {
            throw new NotImplementedException();
        }

        public void UpdateAbilityType(AbilityType1 AbilityType)
        {
            throw new NotImplementedException();
        }
    }
}
