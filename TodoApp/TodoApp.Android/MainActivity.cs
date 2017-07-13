using System;
using System.IO;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Environment = System.Environment;

namespace TodoApp.Droid
{
    [Activity(Label = "TodoApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

#if DEBUG
            CopyDatabase();
#endif

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
#if DEBUG
        private async void CopyDatabase()
        {
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var dbPath = Path.Combine(path, "todo.db3");

            var external = Android.OS.Environment
                .GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).AbsolutePath;

            var externalPath = Path.Combine(external, "todo-backup.db3");

            if(!File.Exists(dbPath))return;

            var origin = File.OpenRead(dbPath);
            var destino = File.Exists(externalPath) ? File.OpenWrite(externalPath) : File.Create(externalPath);

            using (origin)
            using (destino)
            {
                await origin.CopyToAsync(destino);
            }
        }
#endif
    }
}

