using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Domain.Entity
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }
        [Required]
        public int RestaurantId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required, Range(1, 5)]
        public int OrderStatus { get; set; }

        public Client Client { get; set; } = null!;
        public Restaurant Restaurant { get; set; } = null!;
        public ICollection<OrderDish> OrderDishes { get; set; } = new List<OrderDish>();
    }
}
