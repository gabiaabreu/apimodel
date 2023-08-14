using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Domain.DTO
{
    public class ClientCreateRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome do cliente é obrigatório"), StringLength(255)]
        public string ClientName { get; set; } = null!;
        [Required(AllowEmptyStrings = false, ErrorMessage = "O email do cliente é obrigatório"), StringLength(255)]
        public string Email { get; set; } = null!;
        [Required(AllowEmptyStrings = false, ErrorMessage = "O endereço do cliente é obrigatório"), StringLength(255)]
        public string ClientAddress { get; set; } = null!;
        [Required(AllowEmptyStrings = false, ErrorMessage = "A cidade do cliente é obrigatória"), StringLength(80)]
        public string City { get; set; } = null!;
        [Required, StringLength(2), MinLength(2, ErrorMessage = "Insira uma UF válida")]
        public string Uf { get; set; } = null!;
        [Required, MinLength(11), MaxLength(11)]
        public string Cpf { get; set; } = null!;
    }
}
