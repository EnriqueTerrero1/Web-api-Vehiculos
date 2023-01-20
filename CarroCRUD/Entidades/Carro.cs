using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.Entidades
{
    public class Carro
    {
        public int Id { get;set; }

        [Required]
        public string Model { get; set; }

        public string Color { get; set; }

        public string año { get; set; }


        public double Costo { get; set; }

        public int MarcaId { get; set; }

        public Marca Marca { get; set; }
    }
}
