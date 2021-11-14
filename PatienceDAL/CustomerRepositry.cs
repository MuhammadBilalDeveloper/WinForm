using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WinFormEntity;

namespace WinFormDAL
{

    public class CustomerRepositry : ICustomerRepositry
    {
        public DataTable GetCustomer(Customer customer)
        {
            try
            {
                DataSet ds = new DataSet();
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString_SQLServer"].ConnectionString;
                List<SqlParameter> parameters = new List<SqlParameter>();
                if (!string.IsNullOrEmpty(customer.CompanyName))
                    parameters.Add(new SqlParameter("@pCompanyName", customer.CompanyName));
                if (!string.IsNullOrEmpty(customer.ContactName))
                    parameters.Add(new SqlParameter("@pContactName", customer.ContactName));
                if (!string.IsNullOrEmpty(customer.ContactTitle))
                    parameters.Add(new SqlParameter("@pContactTitle", customer.ContactTitle));
                if (!string.IsNullOrEmpty(customer.Phone))
                    parameters.Add(new SqlParameter("@pPhone", customer.Phone));
                if (!string.IsNullOrEmpty(customer.Fax))
                    parameters.Add(new SqlParameter("@pFax", customer.Fax));
                ds = SqlHelper.ExecuteDataset(constr, CommandType.StoredProcedure, "[dbo].[UspGetCustomers]", parameters.ToArray());
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveUpdateCustomer(Customer customer)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString_SQLServer"].ConnectionString;
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@pCustomerID", customer.CustomerID));
                parameters.Add(new SqlParameter("@pCompanyName", customer.CompanyName));
                parameters.Add(new SqlParameter("@pContactName", customer.ContactName));
                parameters.Add(new SqlParameter("@pContactTitle", customer.ContactTitle));
                parameters.Add(new SqlParameter("@pAddress", customer.Address));
                parameters.Add(new SqlParameter("@pCity", customer.City));
                parameters.Add(new SqlParameter("@pRegion", customer.Region));
                parameters.Add(new SqlParameter("@pPostalCode", customer.PostalCode));
                parameters.Add(new SqlParameter("@pCountry", customer.Country));
                parameters.Add(new SqlParameter("@pPhone", customer.Phone));
                parameters.Add(new SqlParameter("@pFax", customer.Fax));
                int rowsAffected = SqlHelper.ExecuteNonQuery(constr, CommandType.StoredProcedure, "[dbo].[UspInsertUpdateCustomers]", parameters.ToArray());
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}