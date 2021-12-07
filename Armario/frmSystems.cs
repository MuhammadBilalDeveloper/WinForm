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
       
        private void frmMainPage_Load(object sender, EventArgs e)
        {
            try
            {
                //DataTable tblHVCoins = new DataTable();
                //tblHVCoins.Columns.Add("System", typeof(string));
                //tblHVCoins.Columns.Add("Symbol", typeof(string));
                //tblHVCoins.Columns.Add("Last Price", typeof(string));
                //tblHVCoins.Columns.Add("Profit", typeof(string));

                //tblHVCoins.Rows.Add("35", "MINA", "40", "1.25");
                //gridControl3.DataSource = tblHVCoins;

                //DataTable tblReCoins = new DataTable();
                //tblReCoins.Columns.Add("Coin", typeof(string));
                //tblReCoins.Columns.Add("Last Price", typeof(string));
                //tblReCoins.Columns.Add("Day Change", typeof(string));
                //tblReCoins.Columns.Add("Quantity", typeof(string));

                //tblReCoins.Rows.Add("MINA", "40.00", "2.25", "500");
                //gridControl4.DataSource = tblReCoins;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
    }
}
