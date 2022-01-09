using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Interfaces;

namespace WEBAPIDemo.Dtos
{
    public class EmployeeDto : IEntityDto
    {
        public Guid Id { get ; set ; }
        public string Name { get; set; }
    }
}
