using CarroCRUD.Entidades;
using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.DTO
{
    public class CarroCreacionDTO
    {



        [Required(ErrorMessage = "Este campo es requerido")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]

        public string Color { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]

        public string año { get; set; }

        [Required (ErrorMessage ="Este campo es requerido")]
        public double Costo { get; set; }

        [Required (ErrorMessage ="Este campo es requerido")]
        public int MarcaId { get; set; }

    }
}
