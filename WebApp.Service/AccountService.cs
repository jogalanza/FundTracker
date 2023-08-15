using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Interface;
using WebApp.Model;

namespace WebApp.Service
{
    public class AccountService : IAccountService
    {
        private readonly IDbService _dbService;

        public AccountService(IDbService dbService)
        {
            _dbService = dbService;
        }
        public async Task<bool> CreateEmployee(Account employee)
        {
            var result =
            await _dbService.EditData(
                "INSERT INTO public.employee (id,name, age, address, mobile_number) VALUES (@Id, @Name, @Age, @Address, @MobileNumber)",
                employee);
            return true;
        }

        public async Task<bool> DeleteEmployee(int key)
        {
            var deleteEmployee = await _dbService.EditData("DELETE FROM public.employee WHERE id=@key", new { key });
            return true;
        }

        public async Task<List<Account>> GetEmployeeList()
        {
            var employeeList = await _dbService.GetAll<Account>("SELECT * FROM public.employee", new { });
            return employeeList;
        }

        public async Task<Account> UpdateEmployee(Account employee)
        {
            var updateEmployee =
            await _dbService.EditData(
                "Update public.employee SET name=@Name, age=@Age, address=@Address, mobile_number=@MobileNumber WHERE id=@Id",
                employee);
            return employee;
        }
    }
}
