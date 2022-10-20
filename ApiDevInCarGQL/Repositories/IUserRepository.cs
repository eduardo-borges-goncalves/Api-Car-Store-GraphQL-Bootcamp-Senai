using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Mutations;

namespace ApiDevInCarGQL.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();

        void AddUser(User user);

        User GetUser(int id);

        User? AuthUser(LoginInput login);
    }
}
