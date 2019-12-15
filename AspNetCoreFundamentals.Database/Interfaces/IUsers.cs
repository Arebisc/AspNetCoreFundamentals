using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreFundamentals.Database.Interfaces
{
    public interface IUsers
    {
        public ICollection<User> UsersData { get; }
    }
}



