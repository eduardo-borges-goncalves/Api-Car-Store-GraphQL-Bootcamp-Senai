using HotChocolate.AspNetCore.Authorization;

namespace ApiDevInCarGQL.Models
{
    public class User
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

        [Authorize]
        public string? Email { get; set; }

        [Authorize]
        public string? Password { get; set; }   
    }
}
