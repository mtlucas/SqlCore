using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlCore
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionsStrings { get; set; }
    }
    public class ConnectionStrings
    {
        public string ConnectionsString { get; set; }
    }

}
