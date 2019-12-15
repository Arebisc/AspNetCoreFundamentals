using AspNetCoreFundamentals.Database;
using AspNetCoreFundamentals.Database.Interfaces;
using AspNetCoreFundamentals.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCoreFundamentals.Services.Users
{
    public class UserDeleter: IUserDeleter
    {
        private readonly IUsers _users;

        public UserDeleter(IUsers users)
        {
            _users = users;
        }

        public User Delete(int userId)
        {
            var entity = _users.UsersData
                 .FirstOrDefault(x => x.Id == userId);

            _users.UsersData.Remove(entity);

            return entity;
        }
    }
}



