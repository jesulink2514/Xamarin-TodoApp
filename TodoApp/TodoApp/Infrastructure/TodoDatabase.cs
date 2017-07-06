using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace TodoApp.Infrastructure
{
    public class TodoDatabase
    {
        private SQLiteConnection database;
        private static object _lock = new object();

        public TodoDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<TodoItem>();
        }

        public int Save(TodoItem todoItem)
        {
            lock (_lock)
            {
                return 0;
            }
        }
    }
}
