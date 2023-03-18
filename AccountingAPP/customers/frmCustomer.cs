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

namespace AccountingAPP
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
           
            Bingrid();

        }
        void Bingrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomer.AutoGenerateColumns = false;
                dgCustomer.DataSource = db.CustomerRepository.GetAllCustomers();
                
            }
        }

        private void txtSreschCustomer_TextChanged(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                dgCustomer.DataSource = db.CustomerRepository.GetCusstomersByFilter(txtSreschCustomer.Text);
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            txtSreschCustomer.Text = "";
            Bingrid();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if(dgCustomer.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgCustomer.CurrentRow.Cells[1].Value.ToString();
                    int customerId = int.Parse(dgCustomer.CurrentRow.Cells[0].Value.ToString());
                    if(MessageBox.Show($"ایا از حذف کردن {name}مطمعن هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                    db.CustomerRepository.DeleteCustomer(customerId);
                    db.save();

                    }
                    
                }
                Bingrid();
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را نتخواب کنید!!");
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEdite frmAdd = new frmAddOrEdite();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                Bingrid();
            }
        }

        private void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomer.CurrentRow!=null)
            {
                int customerId = int.Parse(dgCustomer.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdite frmEdit = new frmAddOrEdite();
                frmEdit.custumerID = customerId;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    Bingrid();
                }
            }
        }
    }
}
