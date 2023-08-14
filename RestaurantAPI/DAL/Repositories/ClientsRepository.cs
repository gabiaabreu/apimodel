using RestaurantAPI.DAL.Base;
using RestaurantAPI.Domain.Entity;

namespace RestaurantAPI.DAL.Repositories
{
    public class ClientsRepository : BaseRepository<Client>
    {
        public ClientsRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
