using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

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

        private void CbParent_Checked(object sender, RoutedEventArgs e)
        {
            if (CbParent.IsChecked == true) {
                CbExtraCheese.IsChecked = true;
                CbHam.IsChecked = true;
                
            }
        }



        private void CbToppingChanged(object sender, RoutedEventArgs e)
        {
            if (CbHam.IsChecked == true && CbExtraCheese.IsChecked==true) {
                CbParent.IsChecked = true;
            }
            else
            {
                CbParent.IsChecked = false;
            }
        }

        private void CbParent_Unchecked(object sender, RoutedEventArgs e)
        {
            if (CbExtraCheese.IsChecked ==true && CbHam.IsChecked == true)
            {
                CbExtraCheese.IsChecked=false;
                CbHam.IsChecked=false;
            }
        }
    }
}
