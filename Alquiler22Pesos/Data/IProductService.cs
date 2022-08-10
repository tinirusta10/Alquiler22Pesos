using Alquiler22Pesos.Entidades;
using Alquiler22Pesos.Pages;

namespace Alquiler22Pesos.Data
{
    public interface IProductService
    {
        Task<IEnumerable<Productos>> GetAllProducts();

        Task<Productos> GetProductDetails(int id);

        Task<bool> InsertProduct(Productos producto);

        Task<bool> UpdateProduct(Productos producto);

        Task<bool> DeleteProduct(int id);

        Task<bool> SaveProduct(Productos producto);

    }
}
