using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hello_wpf
{
    /// <summary>  
    /// Interaction logic for MainWindow.xaml  
    /// </summary>  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                Task.Delay(3000).Wait();

                // Fix: Use the correct instance of the Button control  
                button.Dispatcher.Invoke(() =>
                {
                    button.Content = "www.wpfsoft.com";
                });
            });
        }
    }
}