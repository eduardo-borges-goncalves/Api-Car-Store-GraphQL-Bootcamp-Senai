using ApiDevInCarGQL.Models;

namespace ApiDevInCarGQL.Seeders
{
    public class CustomerSeed
    {
        public static List<Customer> CustomerSeeders { get; set; } = new List<Customer>
        {
            new Customer() { IdCustomer = 1, Name = "Pedro", Cpf = "01101101101" },
            new Customer() { IdCustomer = 2, Name = "Marcia", Cpf = "01181101101" },
            new Customer() { IdCustomer = 3, Name = "Alfredo", Cpf = "01101901101" },
        };
    }
}
