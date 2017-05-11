using SyncHelper.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace TablesLibrary
{
    public class Location : ITable<Location>
    {
        public int ID { get; set; }
        public List<ForeignKey> ForeignKeys { get; set; }
        public string LocalClientID { get; set; }

        public void SetForeignKeys()
        {
            ForeignKeys = new List<ForeignKey>()
            {
                new ForeignKey()
                {
                    NetworkForeignKeyName = nameof(Client.ClientID),
                    ForeignTableType = typeof(Client), 
                }
            };
        }
    }
}
