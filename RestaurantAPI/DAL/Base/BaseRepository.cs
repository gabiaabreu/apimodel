namespace RestaurantAPI.DAL.Base
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly AppDbContext _dbContext;

        public BaseRepository(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<T?> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Create(T newObj)
        {
            _dbContext.Add(newObj);
            await _dbContext.SaveChangesAsync();
            return newObj;
        }
    }
}
