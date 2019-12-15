using AspNetCoreFundamentals.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreFundamentals.Services.Interfaces
{
    public interface IUserDeleter
    {
        User Delete(int id);
    }
}


