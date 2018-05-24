using System.Collections.Generic;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private IUserService _userService;
        private IUserRepository _userRepository;

        public UsersController(IUserService userService, IUserRepository userRepository)
        {
            this._userService = userService;
            this._userRepository = userRepository;
        }

        // GET api/users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "user1", "user2" };
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"user{id}";
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}