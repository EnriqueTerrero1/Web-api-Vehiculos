using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.DTO
{
    public class MarcaCreacionDTO
    {
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Name { get; set; }
    }
}
