using System;
using System.Configuration;
using System.Data;

namespace WinFormDAL
{
    public class InvoiceRepositry : IInvoiceRepositry
    {
        public DataTable GetInvoice()
        {
            try
            {
                DataSet ds = new DataSet();
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString_SQLServer"].ConnectionString;
                ds = SqlHelper.ExecuteDataset(constr, CommandType.StoredProcedure, "[dbo].[UspGetInvoices]");
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
