using AspNetCoreFundamentals.Database;
using AspNetCoreFundamentals.Database.Interfaces;
using AspNetCoreFundamentals.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCoreFundamentals.Services.Users
{
    public class UserGetter : IUserGetter
    {
        private readonly IUsers _users;

        public UserGetter(IUsers users)
        {
            _users = users;
        }

        public ICollection<User> GetUsers()
        {
            return _users.UsersData;
        }

        public User GetUser(int id)
        {
            return _users.UsersData.FirstOrDefault(x => x.Id == id);
        }
    }
}


