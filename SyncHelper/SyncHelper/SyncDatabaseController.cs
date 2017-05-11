using SyncHelper.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SyncHelper
{
    public class SyncDatabaseController
    {
        public void CreateDatabase()
        {
            SQLiteDatabaseManager.CreateDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("Farmflo.db3"));
        }

        public void CreateTable<T>() where T : new()
        {
            try
            {
                SQLiteDatabaseManager.CreateTable<T>();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void DropTable<T>() where T : new()
        {
            SQLiteDatabaseManager.DropTable<T>();
        }

        public void InsertItem<T>(T item) where T : new()
        {
            SQLiteDatabaseManager.InsertTableItem<T>(item);
        }

        public void UpdateItem<T>(T item) where T : new()
        {
            SQLiteDatabaseManager.UpdateTableItem<T>(item);
        }

        public void InsertOrUpdateItem<T>(T item) where T : new()
        {
            SQLiteDatabaseManager.InsertOrUpdateTableItem<T>(item);
        }

        public void DeleteItem<T>(T item) where T : new()
        {
            SQLiteDatabaseManager.DeleteTableItem<T>(item);
        }

        public T GetItem<T>(Expression<Func<T, bool>> exp = null) where T : new()
        {
            return SQLiteDatabaseManager.GetTableItem<T>(exp);
        }

        public List<T> GetItems<T>(Expression<Func<T, bool>> exp = null) where T : new()
        {
            return SQLiteDatabaseManager.GetTableItems<T>(exp);
        }
    }
}
