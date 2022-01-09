using System;
using WEBAPIDemo.Interfaces;

namespace WEBAPIDemo.Models
{
    public class Product: IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string Description { get; set; }
    }
}
