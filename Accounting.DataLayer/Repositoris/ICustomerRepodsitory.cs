using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Customer;

namespace Accounting.DataLayer.Repositoris
{
   public interface ICustomerRepodsitory
    {
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCusstomersByFilter(string parameter);
        List<ListCustomerViiewModel> GetCustomerByName(string fillter = "");
        Customers GetCustomerById(int customerId);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
        int GetCustoumerByName(string name);
        string GetCustomerNameById(int customerid);
    }
}
