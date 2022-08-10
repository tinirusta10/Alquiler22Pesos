using Alquiler22Pesos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Alquiler22Pesos.Data
{
    public class PersonService : IPersonService
    {
        private readonly dbcontext _context;
        //J
        public PersonService(dbcontext context)
        {
            _context = context;
        }

        public async Task<bool> DeletePerson(int id)
        {
            var person = await _context.Persona.FindAsync(id);

            _context.Persona.Remove(person);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Persona>> GetAllPersons()
        {
            return await _context.Persona.ToListAsync();
        }

        public async Task<Persona> GetPersonDetails(int id)
        {
            return await _context.Persona.FindAsync(id);

        }

        public async Task<bool> InsertPerson(Persona persona)
        {
            _context.Persona.Add(persona);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SavePerson(Persona persona)
        {
            if(persona.Id > 0)
            {
                return await UpdatePerson(persona);
            }
            else
            {
                return await InsertPerson(persona);
            }
        }

        public async Task<bool> UpdatePerson(Persona persona)
        {
           _context.Entry(persona).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
