using Alquiler22Pesos.Entidades;

namespace Alquiler22Pesos.Data
{
    public interface IPersonService
    {
        Task<IEnumerable<Persona>> GetAllPersons();

        Task<Persona> GetPersonDetails(int id);

        Task<bool> InsertPerson(Persona persona);

        Task<bool> UpdatePerson(Persona persona);

        Task<bool> DeletePerson(int id);

        Task<bool> SavePerson(Persona persona);
    }
}
