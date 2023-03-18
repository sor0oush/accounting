using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositoris;
using Accounting.DataLayer.Services;
using Accounting.DataLayer;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        private ICustomerRepodsitory _CustomerRepository;
        public ICustomerRepodsitory CustomerRepository
        {
            get
            {
                if (_CustomerRepository == null)
                {
                    _CustomerRepository = new CustomerRepository(db);

                }
                return _CustomerRepository;
            }


        }
        private GenericRipositori<Acccounting> _accountingRepository;
        private GenericRipositori<Login> _loginRepository;
        public GenericRipositori<Login> LoginRepository { get
            {
                if(_loginRepository == null)
                {
                    _loginRepository = new GenericRipositori<Login>(db);
                }
                return _loginRepository;
                    
            }
        }

        public GenericRipositori<Acccounting> AccuntingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new GenericRipositori<Acccounting>(db);

                }
                return _accountingRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
       public void save()
        {
            db.SaveChanges();
        }
    }
}
