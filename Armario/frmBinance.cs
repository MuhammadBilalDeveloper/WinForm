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
    public partial class frmBinance : DevExpress.XtraEditors.XtraForm
    {
        public frmBinance()
        {
            InitializeComponent();
        }
        // Applying singelton pattern
        private static frmBinance instance;
        public static frmBinance Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new frmBinance();
                return instance;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}