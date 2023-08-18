using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Domain.DTO
{
    public class ClientUpdateRequest
    {
        [StringLength(255)]
        public string? ClientName { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        [StringLength(255)]
        public string? ClientAddress { get; set; }
        [StringLength(80)]
        public string? City { get; set; }
        [StringLength(2, ErrorMessage = "Insert a valid UF"), MinLength(2, ErrorMessage = "Insert a valid UF")]
        public string? Uf { get; set; }
        [MinLength(11, ErrorMessage = "Insert a valid CPF, only numbers"), MaxLength(11, ErrorMessage = "Insert a valid CPF, only numbers")]
        public string? Cpf { get; set; }
    }
}
