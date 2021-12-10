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
    public partial class frmSystems : XtraForm
    {
        // Appling Dependency Injection/Inversion
        private readonly ICustomerRepositry _customerRepositry;
        public frmSystems(ICustomerRepositry customerRepositry)
        {
            InitializeComponent();
            _customerRepositry = customerRepositry;
        }
        // Applying singelton pattern
        private static frmSystems instance;
        public static frmSystems Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmSystems(new SQLServerCustomerRepositry());
                }
                return instance;
            }
        }
       
       

        private void frmSystems_Load(object sender, EventArgs e)
        {
            DataTable tblReCoins = new DataTable();
            tblReCoins.Columns.Add("ID", typeof(string));
            tblReCoins.Columns.Add("Symbol", typeof(string));
            tblReCoins.Columns.Add("How Much", typeof(string));
            tblReCoins.Columns.Add("M/A", typeof(string));
            tblReCoins.Columns.Add("In Target", typeof(string));
            tblReCoins.Columns.Add("Out Target", typeof(string));
            tblReCoins.Columns.Add("Buy Ratio", typeof(string));
            tblReCoins.Columns.Add("Moving Stop", typeof(string));
            tblReCoins.Columns.Add("Target Profit", typeof(string));

            tblReCoins.Rows.Add("3","Mina", "400", "M", "4.05", "5.06", "NA", "NA", "NA");
            gridControl3.DataSource = tblReCoins;
        }
    }
}
