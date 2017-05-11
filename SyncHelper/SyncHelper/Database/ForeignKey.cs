using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncHelper.Database
{
    public class ForeignKey
    {
        public string NetworkForeignKeyName { get; set; }

        public Type ForeignTableType { get; set; }

        public int LocalForeignKey { get; set; }

        public string NetworkForeignKey { get; set; }
    }
}
