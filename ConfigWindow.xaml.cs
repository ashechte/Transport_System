﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using BO;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for ConfigWindow.xaml
    /// </summary>
    public partial class ConfigWindow : Window
    {
        private BL.IBL bl;
        public ConfigWindow()
        {
            bl = BL.Factory.GetBL();
            InitializeComponent();
            configList.ItemsSource = bl.getConfig();
        }

        private void ChangeConfig_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
