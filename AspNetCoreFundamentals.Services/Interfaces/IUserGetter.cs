using AspNetCoreFundamentals.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreFundamentals.Services.Interfaces
{
    public interface IUserGetter
    {
        public ICollection<User> GetUsers();
        public User GetUser(int id);
    }
}


