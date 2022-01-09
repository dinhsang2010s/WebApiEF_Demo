using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Dtos;
using WEBAPIDemo.Interfaces;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Handlers
{
    public class EmployeeHandler : IEmployeeHandler
    {
        private readonly IEmployeeRepository repo;
        private readonly IMapper map;
        public EmployeeHandler(IEmployeeRepository repo, IMapper map)
        {
            this.repo = repo;
            this.map = map;
        }
        /// <summary>
        /// Thêm 1 Employee mới vào cơ sở dữ liệu
        /// </summary>
        /// <param name="empDto"></param>
        /// <returns></returns>
        public async Task<EmployeeDto> AddEmployee(EmployeeDto empDto)
        {
            // Xử lý login trước khi thêm employee vào hệ thống
            var newItem = map.Map<EmployeeDto, Employee>(empDto);
            var res = await repo.InserAsync(newItem);
            return map.Map<Employee, EmployeeDto>(res);
        }
        /// <summary>
        /// Lấy danh sách Employee từ cơ sở dữ liệu theo filter 
        /// </summary>
        /// <param name="filter">chuỗi điều kiện</param>
        /// <returns></returns>
        public async Task<IEnumerable<EmployeeDto>> GetListEmployee(string filter)
        {
            // Xử lý login trước khi thêm employee vào hệ thống
            var res = await repo.GetListAsync(filter);
            return map.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(res);

        }
    }
}
