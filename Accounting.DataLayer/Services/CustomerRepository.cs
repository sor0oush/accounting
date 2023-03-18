using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositoris;
using Accounting.ViewModels.Customer;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepodsitory
    {
        private Accounting_DBEntities db;

        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public IEnumerable<Customers> GetCusstomersByFilter(string parameter)
        {
            return db.Customers.Where(c =>
                c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
        }

        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customers customer)
        {  //  try
            // {
            var local = db.Set<Customers>()
                .Local
                .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified;
            return true;
            // }
            //  catch
            // {
            //      return false;
            // }
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ListCustomerViiewModel> GetCustomerByName(string fillter = "")
        {

            if (fillter == "")
            {
                return db.Customers.Select(c => new ListCustomerViiewModel()
                {
                    CustomerID = c.CustomerID 
                    ,FullName=c.FullName
                }).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(fillter)).Select(c=> new ListCustomerViiewModel()
            {
                CustomerID = c.CustomerID
                    ,
                FullName = c.FullName
            }).ToList(); 
        }

        public int GetCustoumerByName(string name)
        {
            return db.Customers.First(c => c.FullName == name).CustomerID;

        }

        public string GetCustomerNameById(int customerid)
        {
            return db.Customers.Find(customerid).FullName;
        }
    }
}
