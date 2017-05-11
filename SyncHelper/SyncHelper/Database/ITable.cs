using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncHelper.Database
{
    public interface ITable<T> where T : class
    {
        int ID { get; set; }

        List<ForeignKey>ForeignKeys {get;set;}
    }
}
