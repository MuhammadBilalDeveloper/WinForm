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
    public partial class frmMainPage : XtraForm
    {
        // Appling Dependency Injection/Inversion
        private readonly ICustomerRepositry _customerRepositry;
        public frmMainPage(ICustomerRepositry customerRepositry)
        {
            InitializeComponent();
            _customerRepositry = customerRepositry;
        }
        // Applying singelton pattern
        private static frmMainPage instance;
        public static frmMainPage Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmMainPage(new SQLServerCustomerRepositry());
                }
                return instance;
            }
        }
       
        private void frmMainPage_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tblHVCoins = new DataTable();
                tblHVCoins.Columns.Add("Coin", typeof(string));
                tblHVCoins.Columns.Add("Last Price ($)", typeof(string));
                tblHVCoins.Columns.Add("Day Change", typeof(string));
                tblHVCoins.Columns.Add("Volume", typeof(string));

                tblHVCoins.Rows.Add("Mina", "40.00", "2.25", "500");
                gridControl3.DataSource = tblHVCoins;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
    }
}
