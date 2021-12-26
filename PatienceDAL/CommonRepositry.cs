using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEntity;

namespace WinFormDAL
{
    public class CommonRepositry : ICommonRepositry
    {
        DataTable ICommonRepositry.GetUser(Users user)
        {
            try
            {

                DataSet ds = new DataSet();
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString_SQLServer"].ConnectionString;
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@pMail", user.Mail));
                parameters.Add(new SqlParameter("@pPassword", user.Password));
               
                ds = SqlHelper.ExecuteDataset(constr, CommandType.StoredProcedure, "[dbo].[UspGetUsers]", parameters.ToArray());

                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
