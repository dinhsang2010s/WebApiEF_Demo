using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using WEBAPIDemo.Interfaces;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyDbContext context;

        public ProductRepository(MyDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                return await context.Products.ToListAsync();
            }
            return await context.Products.Where(filter).ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(Guid productId)
        {
            return await context.Products.FindAsync(productId);
        }

        public async Task InsertProductAsync(Product product)
        {
            await context.Products.AddAsync(product);
        }

        public async Task DeleteProductAsync(Guid productId)
        {
            Product Product = await context.Products.FindAsync(productId);
            context.Products.Remove(Product);
        }

        public async Task UpdateProductAsync(Product Product)
        {
            context.Entry(Product).State = EntityState.Modified;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }


    }
}
