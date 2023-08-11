using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Domain.Entity
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string ClientName { get; set; } = null!;
        [Required, StringLength(255)]
        public string Email { get; set; } = null!;
        [Required, StringLength(255)]
        public string ClientAddress { get; set; } = null!;
        [Required, StringLength(80)]
        public string City { get; set; } = null!;
        [Required, StringLength(2)]
        public string Uf { get; set; } = null!;
        [Required, MinLength(11), MaxLength(11)]
        public string Cpf { get; set; } = null!;
        [Required, Range(1, 2)]
        public int ClientStatus { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
