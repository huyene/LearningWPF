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


        private void ObamaRadioButotn_Checked(object sender, RoutedEventArgs e)
        {
            var ObamaTextBlock = new TextBlock();
            AccessText ObamaAccessText = new AccessText();
            ObamaAccessText.Text = "Obama have ran away";
            Image ObamaImage = new Image();
            BitmapImage ObamaBitmapImage = new BitmapImage(new Uri("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmediaproxy.salon.com%2Fwidth%2F960%2Fhttps%3A%2F%2Fmedia.salon.com%2F2011%2F07%2Fdid_obama_kill_the_confidence_fairy.jpg&f=1&nofb=1&ipt=011d5f56f8c270374e5556e11e2a3f67df4731d906603c4ebf953cec1434a58b&ipo=images"));
            ObamaImage.Source = ObamaBitmapImage;
            ObamaImage.Height = 30;
            ObamaTextBlock.Inlines.Add(ObamaImage);
            ObamaTextBlock.Inlines.Add(ObamaAccessText);
            ObamaRadioButton.Content = ObamaTextBlock;
        }


        private void TrumpRadioButton_Click(object sender, RoutedEventArgs e)
        {
            TrumpRadioButton.FontSize += 1;
        }

        private void ObamaRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ObamaRadioButton.Content = "Obama last name is ...";

        }

        private void BidenRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TrumpRadioButton.FontSize = 20;
        }
    }
}
