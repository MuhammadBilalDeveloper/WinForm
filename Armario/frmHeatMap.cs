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
    public partial class frmHeatMap : XtraForm
    {
        // Appling Dependency Injection/Inversion
        private readonly ICustomerRepositry _customerRepositry;
        public frmHeatMap(ICustomerRepositry customerRepositry)
        {
            InitializeComponent();
            _customerRepositry = customerRepositry;
        }
        // Applying singelton pattern
        private static frmHeatMap instance;
        public static frmHeatMap Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmHeatMap(new SQLServerCustomerRepositry());
                }
                return instance;
            }
        }
       
       

        private void frmHeatMap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
