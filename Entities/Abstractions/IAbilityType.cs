using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstractions
{
    interface IAbilityType<T>
    {
        // Create , Read, Update, Delete
        IEnumerable<T> ReadInAbilityType();
        void CreateAbilityType(T AbilityType);
        void UpdateAbilityType(T AbilityType);
        void DeleteAbilityType(int Id);
    }
}
