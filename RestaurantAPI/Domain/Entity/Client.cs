using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Domain.Entity
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        
        public string ClientName { get; set; } = null!;
        
        public string Email { get; set; } = null!;
        
        public string ClientAddress { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Uf { get; set; } = null!;
        
        public string Cpf { get; set; } = null!;
        
        public int ClientStatus { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
