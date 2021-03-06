﻿using System;
using System.IO;
using SQLite;
using TodoApp.Infrastructure;

[assembly:Xamarin.Forms.Dependency(typeof(TodoApp.Droid.SQLite))]
namespace TodoApp.Droid
{
    public class SQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var dbPath = Path.Combine(path, "todo.db3");
            return new SQLiteConnection(dbPath);
        }
    }
}