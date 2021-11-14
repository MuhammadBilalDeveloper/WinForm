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
using WinFormDAL;
using WinFormEntity;

namespace WinForm
{
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerRepositry _customerRepositry;
        public frmAddCustomer(ICustomerRepositry customerRepositry)
        {
            InitializeComponent();
            _customerRepositry = customerRepositry;
        }
        // Applying singelton pattern
        private static frmAddCustomer instance;
        public static frmAddCustomer Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new frmAddCustomer(new CustomerRepositry());
                return instance;
            }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var ObjCustomer = new Customer();
                //bool Validate = true;
                if (string.IsNullOrEmpty(txtCompamyName.Text))
                {
                    XtraMessageBox.Show("Please enter company name.", Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Validate = false;
                    return;
                }
                if (string.IsNullOrEmpty(txtContactName.Text))
                {
                    XtraMessageBox.Show("Please enter contact name.", Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Validate = false;
                    return;
                }
                ObjCustomer.CompanyName = txtCompamyName.Text;
                var CustomerID = txtCompamyName.Text.Trim();
                var length = txtCompamyName.Text.Length > 5 ? 5 : txtCompamyName.Text.Length;
                ObjCustomer.CustomerID = RemoveWhitespace(CustomerID).Substring(0, length).ToUpper();
                ObjCustomer.ContactName = txtContactName.Text;
                ObjCustomer.ContactTitle = txtContactTitle.Text;
                ObjCustomer.Address = txtAddress.Text;
                ObjCustomer.City = txtCity.Text;
                ObjCustomer.Region = txtRegion.Text;
                ObjCustomer.PostalCode = txtPostalCode.Text;
                ObjCustomer.Country = txtCountry.Text;
                ObjCustomer.Phone = txtPhone.Text;
                ObjCustomer.Fax = txtFax.Text;
                int rows = _customerRepositry.SaveUpdateCustomer(ObjCustomer);
                XtraMessageBox.Show("Customer saved successfully.", Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompamyName.Text = string.Empty;
            txtContactName.Text = string.Empty;
            txtContactTitle.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtRegion.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtFax.Text = string.Empty;


        }
        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }


    }
}