using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Core
{
   public class Connection
    {
        private protected readonly SqlConnection GetConnection= new SqlConnection(@"Server=.\sqlexpress01; Database=SultansKitchen; User Id=sa; Password=123456789;");
    }
}
