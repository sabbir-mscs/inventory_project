using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Core.Context;
using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Repository
{
   public class ProductRepository:IProductRepository
   {
       private readonly InventoryDbContext _dbContext;

       public ProductRepository(InventoryDbContext dbContext)
       {
           _dbContext = dbContext;
       }

        public async Task CreateAsync(Product product)
        {
            _dbContext.Products.Add(product);
           await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAll()
        {
          return await _dbContext.Products.ToListAsync();
        }

        public Task<Product> GetProductById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, Product product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }

   

    
}
