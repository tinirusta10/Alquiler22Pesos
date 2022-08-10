using Alquiler22Pesos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Alquiler22Pesos.Data
{
    public class ProductService : IProductService
    {
        private readonly dbcontext _context;

        public ProductService(dbcontext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _context.productos.FindAsync(id);

            _context.productos.Remove(product);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Productos>> GetAllProducts()
        {
            return await _context.productos.ToListAsync();
        }

        public async Task<Productos> GetProductDetails(int id)
        {
            return await _context.productos.FindAsync(id);
        }

        public async Task<bool> InsertProduct(Productos producto)
        {
            _context.productos.Add(producto);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveProduct(Productos producto)
        {
            if (producto.Id > 0)
            {
                return await UpdateProduct(producto);
            }
            else
            {
                return await InsertProduct(producto);
            }
        }

        public async Task<bool> UpdateProduct(Productos producto)
        {
            _context.Entry(producto).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
