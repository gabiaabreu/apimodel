using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Domain.Entity
{
    [Table("Dishes")]
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string DishName { get; set; } = null!;
        [Required, StringLength(400)]
        public string Description { get; set; } = null!;
        [Required]
        public double Price { get; set; }

        public ICollection<OrderDish> OrderDishes { get; set; } = new List<OrderDish>();
    }
}
