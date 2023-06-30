using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Domain.DTO
{
    public class OrderCreateRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fill dish name")]
        [StringLength(255)]
        public string Dish { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Fill order price"), Range(0, 10000, ErrorMessage = "Price can't be a negative number")]
        public double Price { get; set; }
        public string? Notes { get; set; }
    }
}
