using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Regular_RPG_Progect.Utils
{
    public static class AssetManager
    {
        public static string GetImagePath(string fileName)
        {
            return Path.Combine(Application.StartupPath, "Assets", fileName);
        }

        public static Image LoadImage(string fileName)
        {
            string path = GetImagePath(fileName);
            return File.Exists(path) ? Image.FromFile(path) : null;
        }
    }
}
