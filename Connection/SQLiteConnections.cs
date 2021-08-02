using Models;
using SQLite;
using System.IO;

namespace Connection
{
    public class SQLiteConnections
    {
        private SQLiteConnection connection;
        public SQLiteConnections()
        {
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sales_system");
            connection = new SQLiteConnection(path);
            connection.CreateTable<TExample>();
        }
    }
}