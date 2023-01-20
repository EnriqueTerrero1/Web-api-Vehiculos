using CarroCRUD.Entidades;
using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.DTO
{
    public class CarroDTO
    {
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        public string Color { get; set; }


        public string año { get; set; }


        public double Costo { get; set; }

        public int MarcaId { get; set; }

        public Marca Marca { get; set; }
    }
}
