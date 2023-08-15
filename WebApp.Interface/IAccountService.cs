using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Interface
{
    public interface IAccountService
    {
        Task<bool> CreateEmployee(Account employee);
        Task<List<Account>> GetEmployeeList();
        Task<Account> UpdateEmployee(Account employee);
        Task<bool> DeleteEmployee(int key);
    }
}
