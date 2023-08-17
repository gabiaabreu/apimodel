using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Domain.DTO
{
    public class PageQueryRequest
    {
        [Range(1, int.MaxValue)]
        public int CurrentPage { get; set; } = 1;

        [Range(1, 50)]
        public int Quantity { get; set; } = 10;
    }
}
