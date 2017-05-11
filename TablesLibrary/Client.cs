using SyncHelper.Database;
using System;
using System.Collections.Generic;

namespace TablesLibrary
{
    public class Client : ITable<Client>
    {
        public int ID { get; set; }
        public string ClientID { get; set; }
        public List<ForeignKey> ForeignKeys { get; set; }
    }
}
