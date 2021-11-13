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

namespace WinForm
{
    public partial class frmInvoices : XtraForm
    {
        // Appling Dependency Injection/Inversion
        private readonly IInvoiceRepositry _invoiceRepositry;
        public frmInvoices(IInvoiceRepositry InvoiceRepositry)
        {
            InitializeComponent();
            _invoiceRepositry = InvoiceRepositry;
        }
        // Applying singelton pattern
        private static frmInvoices instance;
        public static frmInvoices Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new frmInvoices(new InvoiceRepositry());
                return instance;
            }
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtInvoice = _invoiceRepositry.GetInvoice();
                gridControlInvoices.DataSource = dtInvoice;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }


    }
}
