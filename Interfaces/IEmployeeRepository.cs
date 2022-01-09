using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> InserAsync(Employee emp);
        Task<IEnumerable<Employee>> GetListAsync(string filter);
    }
}
