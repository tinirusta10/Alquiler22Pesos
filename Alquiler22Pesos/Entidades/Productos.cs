using System.ComponentModel.DataAnnotations;

namespace Alquiler22Pesos.Entidades
{
    public class Productos
    {

        [Required]
        [MaxLength(10)]
        public int Id { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "El Nombre no debe superar los 50 caracteres")]
        public string NombreProducto { get; set; }



        [Required]
        [MaxLength(20)]
        public float PrecioProducto { get; set; }


        [Required]
        [MaxLength(300, ErrorMessage = "El numero de caracteres no debe superar los 300 ")]
        public string DetallesProducto { get; set; }


        [Required]
        [MaxLength(200)]
        public string FotoProducto { get; set; }

    }
}
