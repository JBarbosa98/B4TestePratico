using System.ComponentModel.DataAnnotations;

namespace B4TestePratico.Models
{
    public class Contact
    {
        public Contact()
        {
            Id = Guid.NewGuid();
            Telephone = 934932185;
            Ddd = 11;
            Type = "Residencial";
        }
        [Key]
        public Guid Id { get; init; }
        public string? Type { get; set; }
        public int Ddd { get; set; }
        public decimal Telephone { get; set; }
    }
}