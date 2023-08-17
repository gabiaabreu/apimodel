using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI.DAL.Base
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly AppDbContext _dbContext;

        public BaseRepository(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<T> Create(T newObj)
        {
            _dbContext.Add(newObj);
            await _dbContext.SaveChangesAsync();
            return newObj;
        }

        public async Task<int> GetCount()
        {
            return await _dbContext.Set<T>().CountAsync();
        }

        public async Task<List<T>> GetAll(int currentPage, int pageQuantity)
        {
            int previousPageQuantity = currentPage * pageQuantity - pageQuantity;

            return await _dbContext
                .Set<T>()
                .Skip(previousPageQuantity)
                .Take(pageQuantity)
                .ToListAsync();
        }

        public virtual async Task<T?> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
