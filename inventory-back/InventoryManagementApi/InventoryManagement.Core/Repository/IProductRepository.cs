using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Core.Entities;

namespace InventoryManagement.Core.Repository
{
   public interface IProductRepository
   {
       public Task CreateAsync(Product product);
       public Task<List<Product>> GetAll();
       public Task<Product> GetProductById(Guid id);
       public Task UpdateAsync(Guid id,Product product);
       public Task Delete(Guid id);
   }
}
