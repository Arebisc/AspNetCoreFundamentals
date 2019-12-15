using AspNetCoreFundamentals.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreFundamentals.Database
{
    public class Users: IUsers
    {
        private readonly ICollection<User> _users;

        public Users()
        {
            _users = new List<User>();
            _users.Add(new User { Id = 0, Name = "Michał" });
        }

        public ICollection<User> UsersData
        {
            get
            {
                return _users;
            }
        }
    }
}


