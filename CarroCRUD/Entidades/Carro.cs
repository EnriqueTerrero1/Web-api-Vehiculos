using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.Entidades
{
    public class Carro
    {
        public int Id { get;set; }

        [Required (ErrorMessage ="Este campo es requerido")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]

        public string Color { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]

        public string año { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]

        public double Costo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]

        public int MarcaId { get; set; }

        public Marca Marca { get; set; }
    }
}
