using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using WEBAPIDemo.Interfaces;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MyDbContext context;
        public EmployeeRepository(MyDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Employee>> GetListAsync(string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                return await context.Employees.ToListAsync();
            }
            return await context.Employees.Where(filter).ToListAsync();
        }

        public async Task<Employee> InserAsync(Employee emp)
        {
            await context.AddAsync(emp);
            await context.SaveChangesAsync();
            return emp;
        }
    }
}
