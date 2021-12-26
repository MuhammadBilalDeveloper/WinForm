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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICommonRepositry _commonRepositry;
        public frmLogin(ICommonRepositry commonRepositry)
        {
            InitializeComponent();
            _commonRepositry = commonRepositry;
        }
        // Applying singelton pattern
        private static frmLogin instance;
        public static frmLogin Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new frmLogin(new CommonRepositry());
                return instance;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var objuser = new Users();
            objuser.Mail = textEdit1.Text.Trim();
            objuser.Password = textEdit2.Text.Trim();
            DataTable dt= _commonRepositry.GetUser(objuser);
            if (dt.Rows.Count > 0)
            {
                var form = frmBinance.Getinstance;
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else 
            {
                XtraMessageBox.Show("Email or Password is not correct.Please try again.", Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

           
        }
    }
}