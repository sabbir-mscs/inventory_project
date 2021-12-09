using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Core.Model;
using InventoryManagement.Core.Service;

namespace InventoryManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAll()
        {
          var result= await _productService.GetAll();
            return Ok(result);
        }
        [HttpPost("Create")]
        public async Task<ActionResult> Create([FromBody]ProductRequestModel model)
        {
           await _productService.Create(model);
            return Ok();
        }
    }
}
