using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Dtos;

namespace WEBAPIDemo.Interfaces
{
    public interface IProductHandler
    {
        Task<IEnumerable<ProductDto>> GetProducts(string filter);
        Task<ProductDto> Add(ProductDto input);
    }
}
