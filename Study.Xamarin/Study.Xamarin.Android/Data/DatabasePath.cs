using System;
using System.IO;
using Xamarin.Forms;
using Study.Xamarin.Data;

[assembly: Dependency(typeof(Study.Xamarin.Droid.Data.DatabasePath))]
namespace Study.Xamarin.Droid.Data
{
    public class DatabasePath : IDatabasePath
    {
        public string GetPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "ContatoDB.db3");
        }
    }
}