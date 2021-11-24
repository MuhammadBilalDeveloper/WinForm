using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WinFormDAL
{
    public class InvoiceRepositry : IInvoiceRepositry
    {
        public DataTable GetInvoice(string CustomerID)
        {
            try
            {
                DataSet ds = new DataSet();
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString_SQLServer"].ConnectionString;
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(CustomerID))
                    parameters.Add(new SqlParameter("@pCustomerID", CustomerID));
                ds = SqlHelper.ExecuteDataset(constr, CommandType.StoredProcedure, "[dbo].[UspGetInvoices]", parameters.ToArray());
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
