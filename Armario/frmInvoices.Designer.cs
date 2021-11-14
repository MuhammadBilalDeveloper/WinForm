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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControlInvoices = new DevExpress.XtraEditors.GroupControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.ShipName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ShipAddress1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.CustomerName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.UnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Quantity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Salesperson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInvoices)).BeginInit();
            this.groupControlInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
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
            this.groupControlInvoices.Controls.Add(this.pivotGridControl1);
            this.groupControlInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlInvoices.Location = new System.Drawing.Point(0, 0);
            this.groupControlInvoices.Name = "groupControlInvoices";
            this.groupControlInvoices.Size = new System.Drawing.Size(1434, 553);
            this.groupControlInvoices.TabIndex = 0;
            this.groupControlInvoices.Text = "Invoices Detail";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.ShipName1,
            this.ShipAddress1,
            this.CustomerName1,
            this.ProductName1,
            this.UnitPrice1,
            this.Quantity1,
            this.ExtendedPrice1,
            this.Salesperson1});
            this.pivotGridControl1.Location = new System.Drawing.Point(2, 20);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1430, 531);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // ShipName1
            // 
            this.ShipName1.AreaIndex = 0;
            this.ShipName1.FieldName = "ShipName";
            this.ShipName1.Name = "ShipName1";
            // 
            // ShipAddress1
            // 
            this.ShipAddress1.AreaIndex = 1;
            this.ShipAddress1.FieldName = "ShipAddress";
            this.ShipAddress1.Name = "ShipAddress1";
            // 
            // CustomerName1
            // 
            this.CustomerName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.CustomerName1.AreaIndex = 0;
            this.CustomerName1.FieldName = "CustomerName";
            this.CustomerName1.Name = "CustomerName1";
            // 
            // ProductName1
            // 
            this.ProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.ProductName1.AreaIndex = 1;
            this.ProductName1.FieldName = "ProductName";
            this.ProductName1.Name = "ProductName1";
            // 
            // UnitPrice1
            // 
            this.UnitPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.UnitPrice1.AreaIndex = 2;
            this.UnitPrice1.FieldName = "UnitPrice";
            this.UnitPrice1.Name = "UnitPrice1";
            // 
            // Quantity1
            // 
            this.Quantity1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Quantity1.AreaIndex = 3;
            this.Quantity1.FieldName = "Quantity";
            this.Quantity1.Name = "Quantity1";
            // 
            // ExtendedPrice1
            // 
            this.ExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.ExtendedPrice1.AreaIndex = 4;
            this.ExtendedPrice1.FieldName = "ExtendedPrice";
            this.ExtendedPrice1.Name = "ExtendedPrice1";
            // 
            // Salesperson1
            // 
            this.Salesperson1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Salesperson1.AreaIndex = 5;
            this.Salesperson1.FieldName = "Salesperson";
            this.Salesperson1.Name = "Salesperson1";
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInvoices)).EndInit();
            this.groupControlInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControlInvoices;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField ShipName1;
        private DevExpress.XtraPivotGrid.PivotGridField ShipAddress1;
        private DevExpress.XtraPivotGrid.PivotGridField CustomerName1;
        private DevExpress.XtraPivotGrid.PivotGridField ProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField UnitPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField Quantity1;
        private DevExpress.XtraPivotGrid.PivotGridField ExtendedPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField Salesperson1;
    }
}