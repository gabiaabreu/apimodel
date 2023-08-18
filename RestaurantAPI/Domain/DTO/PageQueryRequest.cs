using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Domain.DTO
{
    public class PageQueryRequest
    {
        [Range(1, int.MaxValue, ErrorMessage = "Page starts with 1")]
        public int CurrentPage { get; set; } = 1;

        [Range(1, 50)]
        public int Quantity { get; set; } = 10;
    }
}
