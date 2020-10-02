using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstractions
{
    interface INodeLocations<T>
    {
        // Create , Read, Update, Delete
        IEnumerable<T> ReadInNodeLocations();
        void CreateNodeLocations(T NodeLocations);
        void UpdateNodeLocations(T NodeLocations);
        void DeleteNodeLocations(int Id);
    }
}
