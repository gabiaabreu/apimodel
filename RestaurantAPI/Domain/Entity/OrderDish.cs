using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Domain.Entity
{
    [Table("OrderDishes")]
    public class OrderDish
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int DishId { get; set; }
        public int Quantity { get; set; } = 1;

        public Order Order { get; set; } = null!;
        public Dish Dish { get; set; } = null!;
    }
}
