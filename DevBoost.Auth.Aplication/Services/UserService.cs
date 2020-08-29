using DevBoost.Auth.Domain.Entities;
using DevBoost.Auth.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.Auth.Aplication.Services
{
    public class UserService : IUserService
    {
        public User Authenticate(string username, string password)
        {
            
            if (username == "teste1")
                return new User(Guid.NewGuid(), username, "123", "ADMIN");

            return new User(Guid.NewGuid(), username, "123", "USER");
        }

        public User GetUser(string userName)
        {
            return new User(Guid.NewGuid(), userName, "123", "admin");
        }
    }
}
