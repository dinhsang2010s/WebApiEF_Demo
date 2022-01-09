using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Dtos;

namespace WEBAPIDemo.Interfaces
{
    public interface IEmployeeHandler
    {
        Task<EmployeeDto> AddEmployee(EmployeeDto empDto);
        Task<IEnumerable<EmployeeDto>> GetListEmployee(string filter);
    }
}
