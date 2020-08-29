using DevBoost.Auth.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace DevBoost.Auth.Domain.Interfaces
{
    public interface IUserService
    {
        User GetUser(string userName);
        User Authenticate(string username, string password);
    }
}
