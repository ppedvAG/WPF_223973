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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventRouting
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

        private void Tbx_Beispiel_TextChanged(object sender, TextChangedEventArgs e)
        {
            Tbl_Output.Text += $"{(sender as FrameworkElement).Name}: TextChanged\n";
        }

        private void Btn_Beispiel_Click(object sender, RoutedEventArgs e)
        {
            Tbl_Output.Text += $"{(sender as FrameworkElement).Name}: Click\n";
        }

        private void Wnd_Main_Click(object sender, RoutedEventArgs e)
        {
            Tbl_Output.Text += $"{(sender as FrameworkElement).Name}: ButtonBase.Click\n";
        }
    }
}