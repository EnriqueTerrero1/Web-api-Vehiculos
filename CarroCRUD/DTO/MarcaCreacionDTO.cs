using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.DTO
{
    public class MarcaCreacionDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
