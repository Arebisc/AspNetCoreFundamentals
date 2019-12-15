using AspNetCoreFundamentals.Database;
using AspNetCoreFundamentals.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreFundamentals.Services.Interfaces
{
    public interface IUserCreator
    {
        public User Create(UserCreatorViewModel user);
    }
}


