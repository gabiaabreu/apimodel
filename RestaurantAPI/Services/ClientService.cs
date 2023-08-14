using RestaurantAPI.DAL;
using RestaurantAPI.DAL.Repositories;
using RestaurantAPI.Domain.DTO;
using RestaurantAPI.Domain.Entity;
using RestaurantAPI.Services.Base;

namespace RestaurantAPI.Services
{
    public class ClientService
    {
        private readonly ClientsRepository _clientsRepository;

        public ClientService(ClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }

        public async Task<ServiceResponse<ClientResponse>> Create(ClientCreateRequest model)
        {
            //if (model.Uf isnt valid)
            //{
            //    return new ServiceResponse<Client>("Preencha uma UF válida");
            //}

            //if (model.Cpf isnt valid)
            //{
            //    return new ServiceResponse<Client>("Preencha um CPF válido");
            //}

            //if (model.Email isnt valid)
            //{
            //    return new ServiceResponse<Client>("Preencha um e-mail válido, como example@mail.com");
            //}

            // email duplicado

            // cpf duplicado

            var newClient = new Client()
            {
                ClientName = model.ClientName,
                Email = model.Email,
                ClientAddress = model.ClientAddress,
                City = model.City,
                Uf = model.Uf,
                Cpf = model.Cpf,
                ClientStatus = 1 // active
            };

            await _clientsRepository.Create(newClient);

            return new ServiceResponse<ClientResponse>(new ClientResponse(newClient));
        }
    }
}
