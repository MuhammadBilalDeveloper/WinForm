using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormEntity;

namespace WinForm
{
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        // Applying singelton pattern
        private static frmAddCustomer instance;
        public static frmAddCustomer Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new frmAddCustomer();
                return instance;
            }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            var ObjCustomer = new Customer();
            ObjCustomer.CompanyName = txtCompamyName.Text;
            ObjCustomer.ContactName = txtContactName.Text;
            ObjCustomer.ContactTitle = txtContactTitle.Text;
            ObjCustomer.Address = txtAddress.Text;
            ObjCustomer.City = txtCity.Text;
            ObjCustomer.Region = txtRegion.Text;
            ObjCustomer.PostalCode = txtPostalCode.Text;
            ObjCustomer.Country = txtCountry.Text;
            ObjCustomer.Phone = txtPhone.Text;
            ObjCustomer.Fax = txtFax.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompamyName.Text = string.Empty;
            txtContactName.Text= string.Empty;
            txtContactTitle.Text= string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtRegion.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtFax.Text = string.Empty;


        }
    }
}