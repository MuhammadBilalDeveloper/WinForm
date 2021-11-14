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
    public partial class frmCustomer : XtraForm
    {
        // Appling Dependency Injection/Inversion
        private readonly ICustomerRepositry _customerRepositry;
        public frmCustomer(ICustomerRepositry customerRepositry)
        {
            InitializeComponent();
            _customerRepositry = customerRepositry;
        }
        // Applying singelton pattern
        private static frmCustomer instance;
        public static frmCustomer Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new frmCustomer(new CustomerRepositry());
                return instance;
            }
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                var ObjCustomer = new Customer();
                DataTable dtCustomer = _customerRepositry.GetCustomer(ObjCustomer);
                gridCustomers.DataSource = dtCustomer;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var ObjCustomer = new Customer();
            ObjCustomer.CompanyName = textEdit1.Text;
            ObjCustomer.ContactName = textEdit2.Text;
            ObjCustomer.ContactTitle = textEdit3.Text;
            ObjCustomer.Phone = textEdit10.Text;
            ObjCustomer.Fax = textEdit9.Text;
            DataTable dtCustomer = _customerRepositry.GetCustomer(ObjCustomer);
            gridCustomers.DataSource = dtCustomer;
        }

        private void Root_Click(object sender, EventArgs e)
        {
            var objfrmAddCustomer = frmAddCustomer.Getinstance;
            DialogResult dr = objfrmAddCustomer.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                objfrmAddCustomer.Close();
            }
            else if (dr == DialogResult.OK)
            {

                objfrmAddCustomer.Close();
            }
            btnSearch_Click(null, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textEdit1.Text = string.Empty;
            textEdit2.Text = string.Empty;
            textEdit3.Text = string.Empty;
            textEdit10.Text = string.Empty;
            textEdit9.Text = string.Empty;
            var ObjCustomer = new Customer();
            DataTable dtCustomer = _customerRepositry.GetCustomer(ObjCustomer);
            gridCustomers.DataSource = dtCustomer;
        }
        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow selectedRow = this.gridView1.GetDataRow(this.gridView1.FocusedRowHandle);
            var CustomerID = selectedRow["CustomerID"].ToString();

        }

        private void btndelete_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow selectedRow = this.gridView1.GetDataRow(this.gridView1.FocusedRowHandle);
            var CustomerID = selectedRow["CustomerID"].ToString();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if (e.Column == ColDelete)
            {
                
            }
        }
    }
}
