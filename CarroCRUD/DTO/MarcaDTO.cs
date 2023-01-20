using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.DTO
{
    public class MarcaDTO
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Name { get; set; }
    }
}
