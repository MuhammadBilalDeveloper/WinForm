using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEntity;

namespace WinFormDAL
{
    public interface ICustomerRepositry
    {
       DataTable GetCustomer(Customer customer);
       //DataTable GetCustomerMySQL(Customer customer);
       int  SaveUpdateCustomer(Customer customer);
       int DeleteCustomer(Customer customer);
    }
}
