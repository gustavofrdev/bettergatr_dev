using System;
using System.Windows;
using GATR_Project.Components;

namespace GATR_Project
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            var (height, width) = StartAppComponent.DefineResoulution();
            Height = height;
            Width = width;
            // Instanciar Classes
            new StartAppComponent();
        }
    }
}