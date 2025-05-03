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

            //#region 异步线程
            //Task.Factory.StartNew(() =>
            //{
            //    Task.Delay(3000).Wait();


            //    // Fix: Use the correct instance of the Button control  
            //    //button.Dispatcher.Invoke(() =>
            //    //{
            //    //    button.Content = "www.wpfsoft.com";
            //    //});              
            //});

            //// 示例1：使用.Result属性
            //Task<int> task0 = CalculateSomethingAsync();
            //int result0 = task0.Result; // 注意：这会阻塞当前线程直到任务完成

            //// 示例3：使用GetAwaiter().GetResult()
            //Task<int> task1 = CalculateSomethingAsync();
            //int result1 = task1.GetAwaiter().GetResult(); // 也会阻塞当前线程

            //// 示例2：使用await（推荐方式）
            //async void SomeMethod()
            //{
            //    Task<int> task = CalculateSomethingAsync();
            //    int result = await task; // 不会阻塞UI线程
            //}

            //#endregion


        }

        // 示例异步方法
        private async Task<int> CalculateSomethingAsync()
        {
            await Task.Delay(1000); // 模拟耗时操作
            return 42;
        }
    }
}