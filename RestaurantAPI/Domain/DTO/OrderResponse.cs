using RestaurantAPI.Domain.Entity;

namespace RestaurantAPI.Domain.DTO
{
    public class OrderResponse
    {
        public OrderResponse(Order order)
        {
            Id = order.Id;
            Dish = order.Dish;
            Description = order.Description;
            Price = order.Price;
            Status = order.Status;
            Notes = order.Notes;
        }

        public int Id { get; set; }
        public string Dish { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
        public string? Notes { get; set; }
    }
}
