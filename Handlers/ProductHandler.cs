using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using WEBAPIDemo.Dtos;
using WEBAPIDemo.Interfaces;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Handlers
{
    public class ProductHandler : IProductHandler
    {
        //private readonly IProductRepository repo;
        private readonly IMapper mapper;
        private readonly IRepository<Product> repo;
        //public ProductHandler(IProductRepository _repo, IMapper _mapper)
        //{
        //    repo = _repo;
        //    mapper = _mapper;
        //}
        public ProductHandler(IRepository<Product> _repo, IMapper _mapper)
        {
            repo = _repo;
            mapper = _mapper;
        }

        public async Task<ProductDto> Add(ProductDto input)
        {
            var newItem = mapper.Map<ProductDto, Product>(input);
            await repo.InsertAsync(newItem);
            await repo.SaveAsync();
            return mapper.Map<Product, ProductDto>(newItem);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts(string filter)
        {
            var products = await repo.GetListAsync(filter);
            //OrderBy(order).Skip((pageIndex - 1) * limit).Take(limit)
            return mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);
        }

    }
}
