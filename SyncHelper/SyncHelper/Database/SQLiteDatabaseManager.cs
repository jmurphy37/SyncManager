using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Linq.Expressions;

namespace SyncHelper.Database
{
    public static class SQLiteDatabaseManager
    {
        static SQLiteAsyncConnection Database;

        public static void CreateDatabase(string filePath)
        {
            Database = new SQLiteAsyncConnection(filePath);
        }

        public static void CreateTable<T>() where T : new()
        {
            Database.CreateTableAsync<T>();
        }

        public static void DropTable<T>() where T: new()
        {
            Database.DropTableAsync<T>();
        }

        public static int InsertTableItem<T>(T item) where T : new()
        {
            return Database.InsertAsync(item).Result;
        }

        public static int InsertOrUpdateTableItem<T>(T item) where T : new()
        {
           return Database.InsertOrReplaceAsync(item).Result;
        }

        public static void DeleteTableItem<T>(T item) where T :new()
        {
            Database.DeleteAsync(item);
        }

        public static void UpdateTableItem<T>(T item) where T : new()
        {
            Database.UpdateAsync(item);
        }

        public static T GetTableItem<T>(Expression<Func<T, bool>> exp = null) where T : new()
        {
            return Database.Table<T>().Where(exp).FirstOrDefaultAsync().Result;
        }

        public static List<T> GetTableItems<T>(Expression<Func<T, bool>> exp = null) where T : new()
        {
            return Database.Table<T>().Where(exp).ToListAsync().Result;
        }
    }
}
