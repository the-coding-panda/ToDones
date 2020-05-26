using ToDones.Data.Models;

namespace ToDones.Application.Abstractions
{
    public interface IUserService
    {
        bool AddUser(string userName, string email);
        User GetUser(int id);
        bool UpdateUser(int id, string email);
        bool DeleteUser(int id);
    }
}
