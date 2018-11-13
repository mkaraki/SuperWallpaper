using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperWallpaper
{
    public partial class WallpaperWindow : Form
    {
        // Import W32 Libs
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        ChromiumWebBrowser Browser;

        public WallpaperWindow()
        {
            InitializeComponent();

            // Get Wallpaper Window ID
            IntPtr Progman = FindWindow("Progman", null);
            // Set Form Parent to Progman
            SetParent(Handle,Progman);

            string cef_url = System.IO.File.ReadAllLines(Program.conf_file,Encoding.UTF8)[0];

            Browser = new ChromiumWebBrowser(cef_url);
            Controls.Add(Browser);
            Browser.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SpWp_NIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WallpaperSettings wpsettings = new WallpaperSettings();

            wpsettings.ShowDialog();
            Application.Restart();
        }
    }
}
