using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstractions
{
    public interface ILoot<T>
    {
        // Create , Read, Update, Delete
        IEnumerable<T> ReadInLoot();
        void CreateLoot(T Loot);
        void UpdateLoot(T Loot);
        void DeleteLoot(int Id);
    }
}
