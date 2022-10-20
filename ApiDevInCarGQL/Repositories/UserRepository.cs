using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Mutations;

namespace ApiDevInCarGQL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>
        {
            new User{
                Id = 1,
                Name = "Eduardo",
                Email = "alemaobrk1@gmail.com",
                Password="123456",
            },
            new User{
                Id = 2,
                Name = "Pedro",
                Email = "pedro@gmail.com",
                Password = "abcdef",
            }
        };

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User? AuthUser(LoginInput login)
        {
            var user = _users.Where(_ => _.Email.ToLower() == login.Email.ToLower() &&
                        _.Password == login.Password).FirstOrDefault();

            return user;
        }

        public User GetUser(int id)
        {
            return _users.Single(q => q.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _users.Where(_ => _.Email.Contains(""));
        }
    }
}
