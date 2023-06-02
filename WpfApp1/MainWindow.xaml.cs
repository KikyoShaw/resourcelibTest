using System;
using System.Windows;
using Vestris.ResourceLib;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string filename = @"C:\Users\shaw\Desktop\222\ColkWallpaper.exe";
            VersionResource versionResource = new VersionResource();
            versionResource.LoadFrom(filename);
            Console.WriteLine("File version: {0}", versionResource.FileVersion);
            versionResource.FileVersion = "1.2.3.4";
            StringFileInfo stringFileInfo = (StringFileInfo)versionResource["StringFileInfo"];
            stringFileInfo["CompanyName"] = "My Company\0";
            stringFileInfo["Weather"] = "Sunshine, beach volleyball.\0";
            versionResource.SaveTo(filename);
        }
    }
}
