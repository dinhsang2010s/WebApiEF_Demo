using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Interfaces;

namespace WEBAPIDemo.Dtos
{
    public class ProductDto: IEntityDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
    }
}
