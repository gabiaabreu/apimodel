using RestaurantAPI.Domain.Entity;

namespace RestaurantAPI.Domain.DTO
{
    public class ClientByIdResponse
    {
        public ClientByIdResponse(Client client)
        {
            Id = client.Id;
            ClientName = client.ClientName;
            Email = client.Email;
            ClientAddress = client.ClientAddress;
            City = client.City;
            Uf = client.Uf;
            Cpf = client.Cpf;
            ClientStatus = client.ClientStatus;
            Orders = client.Orders.Select(order => new OrderResponse(order)).ToList();
        }

        public ClientByIdResponse() { }

        public int Id { get; set; }
        public string ClientName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ClientAddress { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Uf { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public int ClientStatus { get; set; }
        public List<OrderResponse> Orders { get; set; }
    }
}
