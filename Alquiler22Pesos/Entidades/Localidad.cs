using Alquiler22Pesos.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Alquiler22Pesos.Entidades
{
    public class Localidad
    {
                                            
        public int Id { get; set; }
        public string NombreLocalidad { get; set; }

    }
}
