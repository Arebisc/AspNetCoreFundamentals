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
    public class UserUpdater : IUserUpdater
    {
        private readonly IUsers _users;

        public UserUpdater(IUsers users)
        {
            _users = users;
        }

        public User Update(int userId, UserCreatorViewModel user)
        {
            var entity = _users.UsersData
                .FirstOrDefault(x => x.Id == userId);

            entity.Name = user.Name;

            return entity;
        }
    }
}


