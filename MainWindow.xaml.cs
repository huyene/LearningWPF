using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
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
            //GoogleHyperlink.NavigateUri = new Uri("http://www.stackoverflow.com");
            //TextBlock myTb = new TextBlock();
            //myTb.Text = "Hello World";
            //myTb.Inlines.Add(". This is an inline text");
            //myTb.Inlines.Add(new Run("\nAnd this is a run text")
            //{
            //    Foreground = Brushes.Magenta,
            //    TextDecorations = TextDecorations.Strikethrough
            //});
            //Hyperlink link = new Hyperlink();
            //link.Inlines.Add("Click me");
            //link.RequestNavigate += GoogleClick;
            //link.NavigateUri = new Uri("https://google.com");
            //myTb.Inlines.Add(link);
            //myTb.Foreground = Brushes.Red;

            //myTb.TextWrapping = TextWrapping.WrapWithOverflow;
            //this.Content = myTb;
        }
        private void GoogleClick(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.ToString())
            {
                UseShellExecute = true
            });
        }
    }
}
