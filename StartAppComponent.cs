using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Drawing;
using static System.Windows.Forms.Screen;
using Point = System.Windows.Point;
using Rectangle = System.Windows.Shapes.Rectangle;
using Size = System.Windows.Size;

namespace GATR_Project
{
    public class StartAppComponent
    {
        private Size _size;
        private Point _location;
        private const int Height = 1920;
        private const int Width = 1080;

        public void StartApp()
        {
            // StartPosition was set to FormStartPosition.Manual in the properties window.
            System.Drawing.Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            double w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            double h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this._location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this._size = new Size(w, h);
        }
    }
}