using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using Accounting.DataLayer.Context;

namespace AccountingAPP
{
    public partial class frmLogin : Form
    {
        public bool isEdit = false;
        public string username;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.Text = "تنطیمات گذرواژه";
                btnWelcome.Text = "ذخیره";
                    
                using(UnitOfWork db = new UnitOfWork())
                {
                    
                    var login = db.LoginRepository.Get().First();
                    txtUserName.Text = login.UserName;
                    txtPassword.Text = login.Password;
                    
                }

            }
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (isEdit)
                    {
                        var login = db.LoginRepository.Get().First();
                        login.UserName= txtUserName.Text;
                        login.Password = txtPassword.Text;
                        db.LoginRepository.Update(login);
                        db.save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.Get(c => c.UserName == txtUserName.Text && c.Password == txtPassword.Text).Any())
                        {

                            DialogResult = DialogResult.OK;
                            username = txtUserName.Text;

                        }
                        else
                        {
                            MessageBox.Show("کاربری با این مشخصات پیدا نشد", "هشدار");
                            txtPassword.Text = "";
                        }


                    }
                }
            }
        }
    }
}
