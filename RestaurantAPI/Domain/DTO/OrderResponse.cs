using RestaurantAPI.Domain.Entity;

namespace RestaurantAPI.Domain.DTO
{
    public class OrderResponse
    {
        public OrderResponse(Order order)
        {
            Id = order.Id;
            RestaurantId = order.RestaurantId;
            OrderDate = order.OrderDate;
            TotalPrice = order.TotalPrice;
            OrderStatus = order.OrderStatus;
        }

        public OrderResponse() { }

        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public int OrderStatus { get; set; }
    }
}
