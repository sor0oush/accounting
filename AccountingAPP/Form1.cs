using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting;
using Accounting.Utility.Convertor;
using Accounting.ViewModels.Accounting;
using Accounting.Business;

namespace AccountingAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomers = new frmCustomer();
            frmCustomers.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginn = new AccountingAPP.frmLogin();
            if (loginn.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                txtdate.Text = DateConvertor.toshamsi(DateTime.Now);
                txtTime.Text = DateTime.Now.ToString("hh:mm:ss");
                report();
            }
            else
            {
                Application.Exit();
            }

           
        }

        void report()
        {
            ReportViewModel report = Account.ReportMainForm();
            labRecive.Text = report.Recive.ToString("#,0");
            labPay.Text = report.Pay.ToString("#,0");
            labBalance.Text = report.AccontBalance.ToString("#,0");
        }

        private void btnNewAccounting_Click(object sender, EventArgs e)
        {
            frmNewAccounting frmNewAccount = new frmNewAccounting();
            frmNewAccount.ShowDialog();
        }

        private void BtnReportPay_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.typeId = 2;
            frm.ShowDialog(); 
        }

        private void BtnReportRecive_Click(object sender, EventArgs e)
        {

            frmReport frm = new frmReport();
            frm.typeId = 1;
            frm.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmLogin editpass = new AccountingAPP.frmLogin();
            editpass.isEdit = true;
            editpass.ShowDialog();
        }

        private void btnRefreshMAin_Click(object sender, EventArgs e)
        {
            report();
        }
    }
}
