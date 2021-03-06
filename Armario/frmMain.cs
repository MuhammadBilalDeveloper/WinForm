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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        // Applying singelton pattern
        private static frmMain instance;
        public static frmMain Getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new frmMain();
                return instance;
            }
        }
        private void barLinkContainerItemCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var form = Application.OpenForms["frmMainPage"];
                if (form == null)
                {
                    form = frmMainPage.Getinstance;
                    form.MdiParent = this;
                    form.Show();
                }
                form.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barLinkContainerItemInvocies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var form = Application.OpenForms["frmMyPage"];
                if (form == null)
                {
                    form = frmMyPage.Getinstance;
                    form.MdiParent = this;
                    form.Show();
                }
                form.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barLinkContainerItemAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var form = Application.OpenForms["frmAddCustomer"];
                if (form == null)
                {
                    form = frmAddCustomer.Getinstance;
                    form.MdiParent = this;
                    form.Show();
                }
                form.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barLinkContainerItemSystems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var form = Application.OpenForms["frmSystems"];
                if (form == null)
                {
                    form = frmSystems.Getinstance;
                    form.MdiParent = this;
                    form.Show();
                }
                form.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barLinkContainerItemHeatMap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var form = Application.OpenForms["frmHeatMap"];
                if (form == null)
                {
                    form = frmHeatMap.Getinstance;
                    form.MdiParent = this;
                    form.Show();
                }
                form.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barLinkContainerItemSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var form = Application.OpenForms["frmSettings"];
                if (form == null)
                {
                    form = frmSettings.Getinstance;
                    form.MdiParent = this;
                    form.Show();
                }
                form.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Utility.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
