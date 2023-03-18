using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using ValidationComponents;


namespace AccountingAPP
{
    public partial class frmAddOrEdite : Form
    {
        public int custumerID = 0; 
        UnitOfWork db = new UnitOfWork();
        public frmAddOrEdite()
        {
            InitializeComponent();
        }

        private void btnChosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                
                picBoxCust.ImageLocation = openfile.FileName; 
            }
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(picBoxCust.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                picBoxCust.Image.Save(path+imageName);
                Customers cust1 = new Customers()
                {
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    FullName = txtFullname.Text,
                    Mobile = txtMobile.Text,
                    CustomerImage = imageName
                    
                };
                if (custumerID == 0)
                {
                    db.CustomerRepository.InsertCustomer(cust1);
                }
                else
                {
                    cust1.CustomerID = custumerID;
                    db.CustomerRepository.UpdateCustomer(cust1);
                }
                db.save();
                DialogResult= DialogResult.OK;
            }
        }

        private void frmAddOrEdite_Load(object sender, EventArgs e)
        {
            if(custumerID != 0)
            {
                this.Text = "ویرایش شخص";
                btnSaveCust.Text = "ویرایش";
                var customer = db.CustomerRepository.GetCustomerById(custumerID);
                txtAddress.Text = customer.Address;
                txtEmail.Text = customer.Email;
                txtFullname.Text = customer.FullName;
                txtMobile.Text = customer.Mobile;
                picBoxCust.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;

            }
        }
    }
}
