using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
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

        public async Task<ServicePagedResponse<ClientResponse>> GetAll(PageQueryRequest queryRequest)
        {
            var list = await _clientsRepository.GetAll(
                queryRequest.CurrentPage,
                queryRequest.Quantity
            );

            var count = await _clientsRepository.GetCount();

            var convertedList = list
                .Select(supplier => new ClientResponse(supplier));

            return new ServicePagedResponse<ClientResponse>(
                convertedList,
                count,
                queryRequest.CurrentPage,
                queryRequest.Quantity
            );
        }

        public async Task<ServiceResponse<ClientByIdResponse>> GetById(int id)
        {
            var client = await _clientsRepository.GetById(id);

            if (client == null)
                return new ServiceResponse<ClientByIdResponse>("Client not found");

            var clientResponse = new ClientByIdResponse(client);

            return new ServiceResponse<ClientByIdResponse>(clientResponse);
        }

        public async Task<ServiceResponse<Client>> Update(int id, ClientUpdateRequest updateRequest)
        {
            var client = await _clientsRepository.GetById(id);

            if (client == null)
                return new ServiceResponse<Client>("Client not found");

            // verificar UF valida
            // verificar email valido 
            // verificar email existente

            client.ClientName = updateRequest.ClientName.IsNullOrEmpty() ? client.ClientName : updateRequest.ClientName;
            client.Email = updateRequest.Email.IsNullOrEmpty() ? client.Email : updateRequest.Email;
            client.ClientAddress = updateRequest.ClientAddress.IsNullOrEmpty() ? client.ClientAddress : updateRequest.ClientAddress;
            client.City = updateRequest.City.IsNullOrEmpty() ? client.City : updateRequest.City;
            client.Uf = updateRequest.Uf.IsNullOrEmpty() ? client.Uf : updateRequest.Uf;
            client.Cpf = updateRequest.Cpf.IsNullOrEmpty() ? client.Cpf : updateRequest.Cpf;

            await _clientsRepository.Update(client);

            return new ServiceResponse<Client>(client);
        }

        public async Task<ServiceResponse<Client>> SwitchStatus(int id)
        {
            var client = await _clientsRepository.GetById(id);

            if (client == null)
                return new ServiceResponse<Client>("Client not found");

            if (client.ClientStatus == 1)
                client.ClientStatus = 2;
            else if (client.ClientStatus == 2)
                client.ClientStatus = 1;

            await _clientsRepository.Update(client);

            return new ServiceResponse<Client>(client);
        }
    }
}
