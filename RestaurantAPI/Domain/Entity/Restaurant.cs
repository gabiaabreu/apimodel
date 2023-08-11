using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Domain.Entity
{
    [Table("Restaurants")]
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string RestaurantName { get; set; } = null!;
        [Required]
        public string RestaurantAddress { get; set; } = null!;
        [Required]
        public string ContactName { get; set; } = null!;
        [Required, MaxLength(11), MinLength(10)]
        public string PhoneNumber { get; set; } = null!;
        [Required, MaxLength(14), MinLength(14)]
        public string Cnpj { get; set; } = null!;
        [Required, StringLength(80)]
        public string City { get; set; } = null!;
        [Required, StringLength(2)]
        public string Uf { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
