using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperWallpaper
{
    public static class Program
    {
        public static string conf_file = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),"SpecialWallpaper.conf");

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!System.IO.File.Exists(conf_file))
                System.IO.File.WriteAllText(conf_file,"https://www.google.com",System.Text.Encoding.UTF8);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WallpaperWindow());
        }
    }
}
