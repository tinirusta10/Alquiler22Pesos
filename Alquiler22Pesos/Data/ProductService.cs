using Alquiler22Pesos.Pages;
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
            var product = await _context.Producto.FindAsync(id);

            _context.Producto.Remove(product);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Producto>> GetAllProducts()
        {
            return await _context.Producto.ToListAsync();
        }

        public async Task<Producto> GetProductDetails(int id)
        {
            return await _context.Producto.FindAsync(id);
        }

        public async Task<bool> InsertProduct(Producto producto)
        {
            _context.Producto.Add(producto);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveProduct(Producto producto)
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

        public async Task<bool> UpdateProduct(Producto producto)
        {
            _context.Entry(producto).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
