using Entities.Abstractions;
using Impact.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    class PlayerAbilityRepo : IRepositoryPlayersAbilities<PlayersAbilities1>
    {
        Game_ImpactContext DB;
        public PlayerAbilityRepo()
        {
            DB = new Game_ImpactContext();
        }
        public PlayerAbilityRepo(Game_ImpactContext DB)
        {
            this.DB = DB ?? throw new ArgumentNullException(nameof(DB));

        }

        public void CreatePlayersAbilities(PlayersAbilities1 PlayersAbilities)
        {
            throw new NotImplementedException();
        }

        public void DeletePlayersAbilities(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlayersAbilities1> ReadInPlayersAbilities()
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayersAbilities(PlayersAbilities1 PlayersAbilities)
        {
            throw new NotImplementedException();
        }
    }
}