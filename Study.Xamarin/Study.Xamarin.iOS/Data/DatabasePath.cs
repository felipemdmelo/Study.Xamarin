using Study.Xamarin.Data;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(Study.Xamarin.iOS.Data.DatabasePath))]
namespace Study.Xamarin.iOS.Data
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