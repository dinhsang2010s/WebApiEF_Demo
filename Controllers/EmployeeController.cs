using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPIDemo.Dtos;
using WEBAPIDemo.Interfaces;

namespace WEBAPIDemo.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeHandler handler;
        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeHandler handler) : base(logger)
        {
            this.handler = handler;
        }
        [HttpPost]
        public async Task<IActionResult> AddNewEmployee(EmployeeDto empDto)
        {
            try
            {
                var res = await handler.AddEmployee(empDto);
                return Ok(res);
            }
            catch (Exception ex)
            {
                logger.LogError($"AddNewEmployee: {ex.Message}");
                return BadRequest();
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployees(string filter)
        {
            try
            {
                var res = await handler.GetListEmployee(filter);
                return Ok(res);
            }
            catch (Exception ex)
            {
                logger.LogError($"GetEmployees: {ex.Message}");
                return NotFound();
            }
        }
    }
}
