using System;
using SQLite;
using TodoApp.Infrastructure;
using System.IO;
[assembly:Xamarin.Forms.Dependency(typeof(TodoApp.iOS.SQLite))]
namespace TodoApp.iOS
{
    public class SQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var personalFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryFolder = Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder,"todos.db3");
            return new SQLiteConnection(path);
        }
    }
}
