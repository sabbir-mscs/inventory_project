using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Model;

namespace InventoryManagement.Core.Service
{
   public interface IProductService
    {
        public Task Create(ProductRequestModel product);
        public Task<List<ProductRequestModel>> GetAll();
        public Task<ProductRequestModel> GetProductById(Guid id);
        public Task Update(Guid id, ProductRequestModel product);
        public Task Delete(Guid id);
    }
}
