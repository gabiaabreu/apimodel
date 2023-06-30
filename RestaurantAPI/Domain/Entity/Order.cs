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
        [StringLength(255)]
        public string Dish { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public int Status { get; set; }
        public string? Notes { get; set; }
    }
}
