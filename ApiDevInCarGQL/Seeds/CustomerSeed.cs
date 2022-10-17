using ApiDevInCarGQL.Models;

namespace ApiDevInCarGQL.Seeders
{
    public class CustomerSeed
    {
        public static List<Customer> CustomerSeeders { get; set; } = new List<Customer>
        {
            new Customer() { Id = 1, Name = "Pedro", Cpf = "01101101101" },
            new Customer() { Id = 2, Name = "Marcia", Cpf = "01181101101" },
            new Customer() { Id = 3, Name = "Alfredo", Cpf = "01101901101" },
        };
    }
}
