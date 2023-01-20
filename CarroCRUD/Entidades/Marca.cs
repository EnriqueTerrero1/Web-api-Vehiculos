using System.ComponentModel.DataAnnotations;

namespace CarroCRUD.Entidades
{
    public class Marca
    {
        public int Id { get;set;}

        [Required]
        public string Name { get; set; }

        public List<Carro> carros { get; set; }
    }
}
