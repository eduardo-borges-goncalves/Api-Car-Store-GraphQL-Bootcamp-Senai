using System.ComponentModel.DataAnnotations;

namespace ApiDevInCarGQL.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(11)]
        public string Cpf { get; set; }
        public string Name { get; set; }
    }
}
