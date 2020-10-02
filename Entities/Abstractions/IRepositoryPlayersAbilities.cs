using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstractions
{
    public interface IRepositoryPlayersAbilities<T>
    {
        // Create , Read, Update, Delete
        IEnumerable<T> ReadInPlayersAbilities();
        void CreatePlayersAbilities(T PlayersAbilities);
        void UpdatePlayersAbilities(T PlayersAbilities);
        void DeletePlayersAbilities(int Id);
    }
}
