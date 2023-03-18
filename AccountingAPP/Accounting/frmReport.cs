using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Customer;
using Accounting.DataLayer;

namespace AccountingAPP
{

    public partial class frmReport : Form
    {
        public int typeId = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViiewModel> list = new List<ListCustomerViiewModel>();
                list.Add(new ListCustomerViiewModel()
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنید"
                    
                });
                list.AddRange(db.CustomerRepository.GetCustomerByName());
                comboCustomer.DataSource =list;
                comboCustomer.DisplayMember = "FullName";
                comboCustomer.ValueMember = "CustomerID";
            }
            if (typeId==1)
            {
                this.Text = "گزارش دریافتی ها ";

            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            fillter();

        }
        void fillter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<Accounting.DataLayer.Acccounting> result = new List<Acccounting>();
                DateTime? startDate;
                DateTime? endDate;
                if ((int)comboCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(comboCustomer.SelectedValue.ToString());
                    result.AddRange(db.AccuntingRepository.Get(c => c.TypeID == typeId && c.CustomerID == customerId));

                }
                else
                {
                    result.AddRange(db.AccuntingRepository.Get(c => c.TypeID == typeId));
                }
                //  dgReport.AutoGenerateColumns = false;
                // dgReport.DataSource = result;

                if (txtFrom.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtFrom.Text);
                    startDate = DateConvertor.tomilady(startDate.Value);
                    result = result.Where(r => r.DataType >= startDate.Value).ToList();
                }
                if (txtTo.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtTo.Text);
                    endDate = DateConvertor.tomilady(endDate.Value);
                    result = result.Where(r => r.DataType <= endDate.Value).ToList();
                }

                dgReport.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                    dgReport.Rows.Add(accounting.ID, customerName, accounting.Amount, accounting.DataType.toshamsi(), accounting.Description);

                }

                //if (txtFrom.Text!= "____/__/__")
                //{
                //    startDate = Convert.ToDateTime(txtFrom.Text);
                //    startDate = DateConvertor.tomilady(startDate.Value);
                //    result = result.Where(s => s.DataType >= startDate).ToList();
                //        }
                //if (txtTo.Text != "____/__/__")
                //{
                //    endDate = Convert.ToDateTime(txtTo.Text);
                //    endDate = DateConvertor.tomilady(endDate.Value);
                //    result = result.Where(s => s.DataType <= endDate).ToList();
                //}

                  
            }
        }

        private void dgReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRefreshAction_Click(object sender, EventArgs e)
        {
            fillter();
        }

        private void btnDeleteAction_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value .ToString());
                if(MessageBox.Show("ایا از حذف مطمعن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using(UnitOfWork db = new UnitOfWork())
                    {
                        db.AccuntingRepository.Delete(id);
                        db.save();
                        fillter();
                    }
                }

            }
        }

        private void btnEditeAction_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                frmNewAccounting frmNew = new frmNewAccounting();
                frmNew.AccountingID = id;
                if (frmNew.ShowDialog() == DialogResult.OK)
                {
                    fillter();
                }
            }
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrintAction_Click(object sender, EventArgs e)
        {
            DataTable dtprint = new DataTable();
            dtprint.Columns.Add("Customer");
            dtprint.Columns.Add("Amount");
            dtprint.Columns.Add("Date");
            dtprint.Columns.Add("Description");

            foreach(DataGridViewRow data in dgReport.Rows)
            {
                dtprint.Rows.Add(
                    data.Cells[1].Value.ToString(),
                    data.Cells[2].Value.ToString(),
                    data.Cells[3].Value.ToString(),
                    data.Cells[4].Value.ToString()


                    );
                
            }
            stiiReport.Load(Application.StartupPath + "/Report.mrt");
            stiiReport.RegData("DT", dtprint);
            stiiReport.Show();
        }
    }
}
