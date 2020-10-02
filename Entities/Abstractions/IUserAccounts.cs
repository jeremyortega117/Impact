using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstractions
{
    public interface IUserAccounts<T>
    {
        // Create , Read, Update, Delete
        IEnumerable<T> ReadInUserAccounts();
        void CreateUserAccounts(T UserAccounts);
        void UpdateUserAccounts(T UserAccounts);
        void DeleteUserAccounts(int Id);
    }
}
