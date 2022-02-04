using System.ComponentModel.DataAnnotations;

namespace MvcVideojuegos.Models
{
    public class Videojuego
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaDeLanzamiento { get; set; }
        public string? Genero { get; set; }
        public string? Plataforma { get; set; }
        public decimal Precio { get; set; }


    }
}
