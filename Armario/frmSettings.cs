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
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        
        private readonly ICustomerRepositry _customerRepositry;
        public frmSettings(ICustomerRepositry customerRepositry)
        {
            InitializeComponent();
            _customerRepositry = customerRepositry;
        }
        // Applying singelton pattern
        private static frmSettings instance;
        public static frmSettings Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmSettings(new SQLServerCustomerRepositry());
                }
                return instance;
            }
        }
    }
}