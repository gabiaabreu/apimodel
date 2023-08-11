using RestaurantAPI.DAL;
using RestaurantAPI.Domain.Entity;
using RestaurantAPI.Services.Base;

namespace RestaurantAPI.Services
{
    public class OrdersService
    {
        private readonly AppDbContext _dbContext;
        public OrdersService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public ServiceResponse<Order> Create(OrderCreateRequest model)
        //{
        //    if (model.Price < 0 || model.Price > 10000)
        //    {
        //        return new ServiceResponse<Order>("Fill with a valid price");
        //    }

        //    if (string.IsNullOrEmpty(model.Dish))
        //    {
        //        return new ServiceResponse<Order>("Fill dish name");
        //    }

        //    var newOrder = new Order()
        //    {
        //        Dish = model.Dish,
        //        Description = model.Description,
        //        Price = model.Price,
        //        Status = 1,
        //        Notes = model.Notes,
        //    };

        //    _dbContext.Add(newOrder);
        //    _dbContext.SaveChanges();

        //    return new ServiceResponse<Order>(newOrder);
        //}
    }
}
