using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Accounting;
using Accounting.DataLayer.Context;

namespace Accounting.Business
{
   public class Account
    {
        public static ReportViewModel  ReportMainForm()
        {
            ReportViewModel rp = new ReportViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month,01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);

                var Recive = db.AccuntingRepository.Get(s=>s.TypeID==1 && s.DataType>=startDate&& s.DataType<=endDate).Select(a=>a.Amount).ToList();
                var Pay = db.AccuntingRepository.Get(s => s.TypeID == 2 && s.DataType >= startDate && s.DataType <= endDate).Select(a => a.Amount).ToList();

                rp.Recive = Recive.Sum();
                rp.Pay = Pay.Sum();
                rp.AccontBalance = (Recive.Sum() - Pay.Sum());
            }
            return rp;

        }
            

    }
}
