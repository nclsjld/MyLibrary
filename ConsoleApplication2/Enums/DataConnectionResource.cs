using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryLibrary.Enums
{
    public enum DataConnectionResource : int
    {
      [StringValue("Server=127.0.0.1;Port=3306;Database=stock_manager;Uid=manager;Pwd=manager")]
      GENERICMYSQL = 1,
      [StringValue("Server=127.0.0.1;Port=3306;Database=stock_manager;Uid=manager;Pwd='manager'")] 
      LOCALMYSQL = 2,
      [StringValue("http://localhost:2253/api/")] 
      LOCALAPI = 3,
    }
}
