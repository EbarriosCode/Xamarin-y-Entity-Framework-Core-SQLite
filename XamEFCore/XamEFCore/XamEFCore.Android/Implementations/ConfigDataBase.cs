using System.IO;
using Xamarin.Forms;
using XamEFCore.Droid.Implementations;
using XamEFCore.Interfaces;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace XamEFCore.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}