using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEntity;

namespace WinFormDAL
{
    public interface ICommonRepositry
    {
       DataTable GetUser(Users user);
      
    }
}
