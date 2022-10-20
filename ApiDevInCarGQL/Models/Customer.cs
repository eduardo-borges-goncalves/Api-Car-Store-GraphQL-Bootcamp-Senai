using System.ComponentModel.DataAnnotations;

namespace ApiDevInCarGQL.Models
{
    public class Customer
    {
        [Key]
        public int IdCustomer { get; set; }
        [StringLength(11)]
        public string Cpf { get; set; }
        public string Name { get; set; }
    }
}
