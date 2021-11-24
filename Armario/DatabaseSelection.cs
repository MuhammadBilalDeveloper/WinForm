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

namespace WinForm
{
    public partial class DatabaseSelection : DevExpress.XtraEditors.XtraForm
    {
        public DatabaseSelection()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Utility.DatabaseSelected = "SQLServer";
            frmMain.Getinstance.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Utility.DatabaseSelected = "MYSQL";
            frmMain.Getinstance.ShowDialog();
        }
    }
}