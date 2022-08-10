

using Alquiler22Pesos.Pages;

namespace Alquiler22Pesos.Data
{
    public interface IProductService
    {
        Task<IEnumerable<Producto>> GetAllProducts();

        Task<Producto> GetProductDetails(int id);

        Task<bool> InsertProduct(Producto producto);

        Task<bool> UpdateProduct(Producto producto);

        Task<bool> DeleteProduct(int id);

        Task<bool> SaveProduct(Producto producto);

    }
}
