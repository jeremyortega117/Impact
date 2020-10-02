using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstractions
{
    interface IUsers<T>
    {
        // Create , Read, Update, Delete
        IEnumerable<T> ReadInUsers();
        void CreateUsers(T Users);
        void UpdateUsers(T Users);
        void DeleteUsers(int Id);
    }
}
