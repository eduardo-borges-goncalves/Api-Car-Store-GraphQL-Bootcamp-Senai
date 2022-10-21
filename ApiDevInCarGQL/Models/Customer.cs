using System.ComponentModel.DataAnnotations;

namespace ApiDevInCarGQL.Models
{
    public class Customer
    {
        public int IdCustomer { get; set; }

        [Key]
        [StringLength(11)]
        public string Cpf { get; set; }
        public string Name { get; set; }
    }
}
