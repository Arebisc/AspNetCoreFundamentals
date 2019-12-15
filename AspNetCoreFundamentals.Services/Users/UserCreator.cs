using AspNetCoreFundamentals.Database;
using AspNetCoreFundamentals.Database.Interfaces;
using AspNetCoreFundamentals.Services.Interfaces;
using AspNetCoreFundamentals.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCoreFundamentals.Services.Users
{
    public class UserCreator : IUserCreator
    {
        private readonly IUsers _users;

        public UserCreator(IUsers users)
        {
            _users = users;
        }

        public User Create(UserCreatorViewModel user)
        {
            var maxId = _users.UsersData.Max(x => x.Id);
            var newUser = new User
            {
                Name = user.Name,
                Id = ++maxId
            };

            _users.UsersData.Add(newUser);
            return newUser;
        }
    }
}


