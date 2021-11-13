namespace WinForm
{
    partial class frmInvoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlInvoices = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControlInvoices = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInvoices)).BeginInit();
            this.groupControlInvoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlInvoices
            // 
            this.gridControlInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlInvoices.Location = new System.Drawing.Point(2, 20);
            this.gridControlInvoices.MainView = this.gridView1;
            this.gridControlInvoices.Name = "gridControlInvoices";
            this.gridControlInvoices.Size = new System.Drawing.Size(1430, 531);
            this.gridControlInvoices.TabIndex = 0;
            this.gridControlInvoices.UseEmbeddedNavigator = true;
            this.gridControlInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlInvoices;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControlInvoices);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1434, 553);
            this.panel1.TabIndex = 0;
            // 
            // groupControlInvoices
            // 
            this.groupControlInvoices.Controls.Add(this.gridControlInvoices);
            this.groupControlInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlInvoices.Location = new System.Drawing.Point(0, 0);
            this.groupControlInvoices.Name = "groupControlInvoices";
            this.groupControlInvoices.Size = new System.Drawing.Size(1434, 553);
            this.groupControlInvoices.TabIndex = 0;
            this.groupControlInvoices.Text = "Invoices Detail";
            // 
            // frmInvoices
            // 
            this.ClientSize = new System.Drawing.Size(1434, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInvoices)).EndInit();
            this.groupControlInvoices.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControlInvoices;
        private DevExpress.XtraGrid.GridControl gridControlInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}