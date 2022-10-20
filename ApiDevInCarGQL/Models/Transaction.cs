using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDevInCarGQL.Models
{
    public class Transaction
    {
        [Required]
        [Key]
        public int? IdTransaction { get; set; }

        [Required]
        [Column("IdCustomer")]
        [ForeignKey("Customer")]
        public string Cpf { get; set; }

        [Required]
        [Column("IdVehicle")]
        [ForeignKey("Vehicle")]
        public int IdVehicle { get; set; }
        public DateTime? Date { get; set; }

        public Transaction() { }
        public Transaction(string cpf, int idVehicle, DateTime? date)
        {
            Cpf = cpf;
            IdVehicle = idVehicle;
            Date = date;
        }
    }
}
