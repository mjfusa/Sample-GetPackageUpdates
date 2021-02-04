﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.Services.Store;

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
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var res = await StoreContext.GetDefault().GetAppAndOptionalStorePackageUpdatesAsync();

            foreach (StorePackageUpdate u in res)
            {
                Debug.WriteLine(u.Package.Dependencies);
                Debug.WriteLine(u.Package.Description);
                Debug.WriteLine(u.Package.DisplayName);
                Debug.WriteLine(u.Package.EffectiveExternalLocation.DisplayName);
                Debug.WriteLine(u.Package.EffectiveExternalPath);
                Debug.WriteLine(u.Package.EffectiveLocation.DisplayName);
                Debug.WriteLine(u.Package.EffectivePath);
                Debug.WriteLine(u.Package.GetAppInstallerInfo());
                Debug.WriteLine(u.Package.InstalledDate);
            }
        }
    }
}
