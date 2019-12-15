using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreFundamentals.Database.Interfaces;
using AspNetCoreFundamentals.Services.Interfaces;
using AspNetCoreFundamentals.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreFundamentals.Web.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        private readonly IUserGetter _usersGetter;
        private readonly IUserCreator _userCreator;
        private readonly IUserUpdater _userUpdater;
        private readonly IUserDeleter _userDeleter;

        public UsersController(
            IUserGetter usersGetter,
            IUserCreator userCreator,
            IUserUpdater userUpdater,
            IUserDeleter userDeleter
            )
        {
            _usersGetter = usersGetter;
            _userCreator = userCreator;
            _userUpdater = userUpdater;
            _userDeleter = userDeleter;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_usersGetter.GetUsers());
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok(_usersGetter.GetUser(id));
        }

        [HttpPost]
        public IActionResult CreateUser(
            [FromBody] UserCreatorViewModel userCreatorViewModel
            )
        {
            return Ok(_userCreator.Create(userCreatorViewModel));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(
            int id,
            [FromBody] UserCreatorViewModel user
            )
        {
            return Ok(_userUpdater.Update(id, user));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            return Ok(_userDeleter.Delete(id));
        }
    }
}



