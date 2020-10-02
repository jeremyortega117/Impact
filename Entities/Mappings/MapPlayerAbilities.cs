using Impact.Models;

namespace Entities.Mappings
{
    class MapPlayerAbilities
    {
        public static PlayersAbilities1 Map(PlayersAbilities Orig)
        {
            return new PlayersAbilities1()
            {
                Id = Orig.Id,
                PlayerId = (int)Orig.PlayerId,
                AbilityId = (int)Orig.AbilityId,
                PlayerAbilityLevel = (int)Orig.PlayerAbilityLevel
            };
        }

        public static PlayersAbilities Map(PlayersAbilities1 Orig)
        {
            return new PlayersAbilities()
            {
                Id = Orig.Id,
                PlayerId = Orig.PlayerId,
                AbilityId = Orig.AbilityId,
                PlayerAbilityLevel = Orig.PlayerAbilityLevel
            };
        }
    }
}
