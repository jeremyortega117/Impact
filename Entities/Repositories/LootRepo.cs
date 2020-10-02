using Entities.Abstractions;
using Impact.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    class LootRepo : ILoot<Loot1>
    {
        Game_ImpactContext DB;
        public LootRepo()
        {
            DB = new Game_ImpactContext();
        }
        public LootRepo(Game_ImpactContext DB)
        {
            this.DB = DB ?? throw new ArgumentNullException(nameof(DB));

        }

        public void CreateLoot(Loot1 Loot)
        {
            throw new NotImplementedException();
        }

        public void DeleteLoot(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loot1> ReadInLoot()
        {
            throw new NotImplementedException();
        }

        public void UpdateLoot(Loot1 Loot)
        {
            throw new NotImplementedException();
        }
    }
}
