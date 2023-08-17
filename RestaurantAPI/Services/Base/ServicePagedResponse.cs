namespace RestaurantAPI.Services.Base
{
    public class ServicePagedResponse<T> : ServiceResponse<IEnumerable<T>>
    {
        public ServicePagedResponse(IEnumerable<T> list, int count, int currentPage, int pageQuantity)
            : base(list)
        {
            CurrentPage = currentPage;
            TotalPages = (int)Math.Ceiling(count / (double)pageQuantity);
        }

        public ServicePagedResponse(string errorMessage) : base(errorMessage)
        {
        }

        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
    }
}
