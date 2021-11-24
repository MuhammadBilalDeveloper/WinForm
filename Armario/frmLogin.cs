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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        // Applying singelton pattern
        private static frmLogin instance;
        public static frmLogin Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new frmLogin();
                return instance;
            }
        }
    }
}