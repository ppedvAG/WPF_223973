using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVM.View
{
    /// <summary>
    /// Interaction logic for StartView.xaml
    /// </summary>
    public partial class StartView : Window
    {
        //Außer dem Konstruktor mit der InitializeComponent()-Methode
        //sollte im CodeBehind der xaml-Dateien nicht stehen

        public StartView()
        {
            InitializeComponent();
        }
    }
}
