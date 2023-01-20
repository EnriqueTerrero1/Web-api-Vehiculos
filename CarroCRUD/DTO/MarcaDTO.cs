using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.DTO
{
    public class MarcaDTO
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
