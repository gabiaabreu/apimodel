using Microsoft.EntityFrameworkCore;
using RestaurantAPI.DAL.Base;
using RestaurantAPI.Domain.Entity;

namespace RestaurantAPI.DAL.Repositories
{
    public class ClientsRepository : BaseRepository<Client>
    {
        public ClientsRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Client?> GetById(int id)
        {
            return await _dbContext
                .Clients
                .Include(x => x.Orders)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
