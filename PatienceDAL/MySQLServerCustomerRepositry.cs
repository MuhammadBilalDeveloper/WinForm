using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEntity;

namespace WinFormDAL
{
    public class MySQLServerCustomerRepositry : ICustomerRepositry
    {
        public int DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public DataTable GetCustomer(Customer customer)
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString_MySQLServer"].ConnectionString;
            string commandText = "SELECT * FROM northwind.customers;";
            return new DataTable();
            //using (MySqlConnection connection = new MySqlConnection(constr))
            //{
            //    //MySqlCommand cmd = new MySqlCommand(commandText, connection);
            //    MySqlDataAdapter returnVal = new MySqlDataAdapter(commandText, connection);
            //    DataTable dt = new DataTable("CharacterInfo");
            //    returnVal.Fill(dt);
            //    return dt;
            //}
        }

        public int SaveUpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
