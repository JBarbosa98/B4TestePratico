using System.ComponentModel.DataAnnotations;

namespace B4TestePratico.Models
{
    public class Client
    {
        public Client(string name)
        {
            Name = name;
            IdClient = new Guid();
            EmailAdress = "joca.flm@outlook.com";
            Cpf = CpfFormat("46887293838");
            Rg = RgFormat("500322235");
            Contact = new Contact();
            Address = new Address();

        }
        [Key]
        public Guid IdClient { get; init; }
        public string? Name { get; set; }
        [EmailAddress]
        public string? EmailAdress { get; set; }
        public string? Cpf { get; set; } 
        public string? Rg { get; set; }

        public Contact? Contact { get; set; }

        public Address? Address { get; set; }

        private string CpfFormat(string cpf) {

            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        private string RgFormat(string rg)
        {

            return Convert.ToUInt64(rg).ToString(@"00\.000\.000\-0");
        }
    }
}
