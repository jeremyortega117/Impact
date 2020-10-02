using Impact.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    class WorldRequirementsRepo : IWorldRequirements<WorldRequirements1>
    {
        Game_ImpactContext DB;
        public WorldRequirementsRepo()
        {
            DB = new Game_ImpactContext();
        }
        public WorldRequirementsRepo(Game_ImpactContext DB)
        {
            this.DB = DB ?? throw new ArgumentNullException(nameof(DB));

        }

        public void CreateWorldRequirements(WorldRequirements1 WorldRequirements)
        {
            throw new NotImplementedException();
        }

        public void DeleteWorldRequirements(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorldRequirements1> ReadInWorldRequirements()
        {
            throw new NotImplementedException();
        }

        public void UpdateWorldRequirements(WorldRequirements1 WorldRequirements)
        {
            throw new NotImplementedException();
        }
    }
}
