using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Timers;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using ValidationComponents;

namespace AccountingAPP
{

    public partial class frmNewAccounting : Form
    {
        UnitOfWork db ;
        public int AccountingID = 0;
        public frmNewAccounting()
        {
            InitializeComponent();
        }

        private void dgCustomerName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmNewAccounting_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgCustomerName.AutoGenerateColumns = false;
            dgCustomerName.DataSource = db.CustomerRepository.GetCustomerByName();
            if(AccountingID != 0)
            {
                var account = db.AccuntingRepository.GetById(AccountingID);
                txtMablagh.Value = account.Amount;
                txtNameCust.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                txtDescription.Text = account.Description;
                if (account.TypeID == 1)
                {
                    rbRecive.Checked = true;

                }
                else
                {
                    rbPay.Checked = true;
                }
                this.Text = "ویرایش";
                btnSaveIt.Text = "ویرایش";
                


            }
            db.Dispose();
        }

     
        private void txtFillter_TextChanged(object sender, EventArgs e)
        {
            dgCustomerName.AutoGenerateColumns = false;
            dgCustomerName.DataSource = db.CustomerRepository.GetCustomerByName(txtfillter.Text);

        }
        private void dgCustomerName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameCust.Text = dgCustomerName.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSaveIt_Click(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecive.Checked)
                {
                    Accounting.DataLayer.Acccounting account = new Accounting.DataLayer.Acccounting()
                    {
                        Amount = int.Parse(txtMablagh.Value.ToString()),
                        CustomerID = db.CustomerRepository.GetCustoumerByName(txtNameCust.Text),
                        TypeID = (rbRecive.Checked) ? 1:2,
                        DataType=DateTime.Now ,
                        Description=txtDescription.Text 
                        
                    };
                    if (AccountingID == 0)
                    {
                        db.AccuntingRepository.Insert(account);

                    }
                    else
                    {
                        
                            account.ID = AccountingID;
                            db.AccuntingRepository.Update(account);
                        
                    }


                    db.save();

                    DialogResult = DialogResult.OK;  

                }
                else
                {
                    MessageBox.Show("لطفا نوع تراکنش را مشخص کنید");
                }

            }
            db.Dispose();
        }
    }
}
