using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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



namespace C_21_4_GUI异步
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnDoStuff_Click(object sender, RoutedEventArgs e)
        {
            btnDoStuff.IsEnabled = false;
            lbStatus.Content = "Doing Stuff";
            //Thread.Sleep(4000);
            await Task.Delay(4000);   // 非阻塞暂停，将自己从处理器弹出，4s后再将自己压入队列
            lbStatus.Content = "Not Doing Anything";
            btnDoStuff.IsEnabled = true;
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Task.Delay");
        }
    }
}