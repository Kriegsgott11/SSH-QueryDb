using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH_QueryDb.Class
{
    public class ConnectonSettings
    {
        public string SSHHost { get; set; }
        public int SSHPort { get; set; }
        public string SSHUser { get; set; }
        public string SSHPass { get; set; }
        public string SQLHost { get; set; }
        public string SQLIPA { get; set; }
        public int SQLPort { get; set; }
        public string SQLConnectionString { get; set; }
        public string SQLCommandQuery { get; set; }
    }
}
