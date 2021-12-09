using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InventoryManagement.Core.Entities;
using InventoryManagement.Core.Model;
using InventoryManagement.Core.Repository;
using InventoryManagement.Core.Service;

namespace InventoryManagement.Service
{
    public class ProductService : IProductService
    {
        private IProductRepository _repo;
        private IMapper _mapper;

        public ProductService(IProductRepository repo, IMapper mapper)
        {
            this._repo = repo;
            _mapper = mapper;
        }

        public async Task Create(ProductRequestModel model)
        {

            var product = _mapper.Map<Product>(model);
            await _repo.CreateAsync(product);
        }

        public async Task<List<ProductRequestModel>> GetAll()
        {
          var products= await _repo.GetAll();
          var modelList = _mapper.Map<List<ProductRequestModel>>(products);
          return modelList;
        }

        public Task<ProductRequestModel> GetProductById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, ProductRequestModel product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
