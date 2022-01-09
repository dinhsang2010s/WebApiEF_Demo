using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync(string filter);
        Task<Product> GetProductByIdAsync(Guid productId);
        Task InsertProductAsync(Product product);
        Task DeleteProductAsync(Guid productId);
        Task UpdateProductAsync(Product product);
        Task SaveAsync();
    }
}
