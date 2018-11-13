using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperWallpaper
{
    public static class Program
    {
        public static string conf_file = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"SuperWallpaper.txt");
        public static string app_dir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public static string readme_url = "file:///" + System.IO.Path.GetFullPath(System.IO.Path.Combine(app_dir, "FactoryHTML", "readme.html")).Replace('\\','/');

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!System.IO.File.Exists(conf_file))
                System.IO.File.WriteAllText(conf_file, readme_url, System.Text.Encoding.UTF8);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WallpaperWindow());
        }
    }
}
