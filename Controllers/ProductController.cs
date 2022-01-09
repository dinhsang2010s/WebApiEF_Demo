using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using WEBAPIDemo.Dtos;
using WEBAPIDemo.Interfaces;

namespace WEBAPIDemo.Controllers
{

    public class ProductController : BaseController
    {
        private readonly IProductHandler _productHandler;
        public ProductController(ILogger<ProductController> logger,
            IProductHandler productHandler) : base(logger)
        {
            _productHandler = productHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetListData(string filter)
        {
            logger.LogInformation($"GetListData: {filter}");
            try
            {
                return Ok(await _productHandler.GetProducts(filter));
            }
            catch (Exception ex)
            {
                logger.LogError($"GetListData: {ex.Message}");
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductDto input)
        {
            logger.LogInformation($"AddProduct: {input.Name}");
            try
            {
                return Ok(await _productHandler.Add(input));
            }
            catch (Exception ex)
            {
                logger.LogError($"AddProduct: {ex.Message}");
                return NotFound();
            }
        }

    }
}
