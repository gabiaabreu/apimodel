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

        public async Task<bool> ExistsByEmail(string email)
        {
            bool emailExists = await _dbContext.Clients.AnyAsync(c => c.Email == email);

            return emailExists;
        }

        public async Task<bool> ExistsByCpf(string cpf)
        {
            bool cpfExists = await _dbContext.Clients.AnyAsync(c => c.Cpf == cpf);

            return cpfExists;
        }
    }
}
