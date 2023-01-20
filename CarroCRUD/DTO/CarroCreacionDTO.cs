using CarroCRUD.Entidades;
using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.DTO
{
    public class CarroCreacionDTO
    {



        [Required]
        public string Model { get; set; }

        public string Color { get; set; }


        public string año { get; set; }

        public double Costo { get; set; }

        public int MarcaId { get; set; }

    }
}
