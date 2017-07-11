using System.IO;
using Windows.Storage;
using SQLite;
using TodoApp.Infrastructure;

[assembly:Xamarin.Forms.Dependency(typeof(TodoApp.UWP.SQLite))]
namespace TodoApp.UWP
{
    public class SQLite: ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path,"todos.db3");
            return new SQLiteConnection(path);
        }
    }
}
