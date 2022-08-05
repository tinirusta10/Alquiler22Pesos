using Alquiler22Pesos.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Alquiler22Pesos.Entidades
{
    public class Departamento
    {
        [Key]
        public int Id{ get; set; }

        public string NombreDepartamento { get; set; }

    }
}
