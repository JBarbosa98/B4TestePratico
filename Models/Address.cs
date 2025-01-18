using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace B4TestePratico.Models
{
    public class Address
    {
        public Address()
        {
            Id = Guid.NewGuid();
            City = "São Paulo";
            State = "SP";
            Street = "rua dos bobos";
            Number = 4;
            Cep = CepFormat("11618273");
            Complement = "condominio de casa";
            Neighborhood = "campo limpo";
            Reference = "ao lado do campo";
            Type = "Entrega";
        }

        [Key]
        public Guid Id { get; init; }
        public string? Type { get; set; }
        public string? Cep { get; set; }
        public string? Street { get; set; }
        public string? Neighborhood { get; set; }
        public int Number { get; set; }
        public string? Complement { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Reference { get; set; }

        private string CepFormat(string cep)
        {

            return Convert.ToUInt64(cep).ToString(@"00000\-000");
        }
    }
}