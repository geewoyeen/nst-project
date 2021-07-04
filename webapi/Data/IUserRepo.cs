using System.Collections.Generic;
using webapi.Models;

namespace webapi.Data
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
    }
}