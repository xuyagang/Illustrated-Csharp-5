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


namespace C_21_6_1_完整的GUI示例
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        CancellationTokenSource cancellationTokenSource;   // 创建可分配给不同任务的CancellationToken对象
        CancellationToken cancellationToken;   // 包含一个任务是否应该被取消的消息

        public MainWindow()
        {InitializeComponent();}


        private async void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            btnProcess.IsEnabled = false;   // 单击后禁用按钮
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;

            int completedPercent = 0;
            for (int i=0; i<10; i++)
            {
                // 如果此令牌已请求取消，则退出循环
                if (cancellationToken.IsCancellationRequested)
                    break;
                try
                {
                    // 创建将在时间延迟后完成的可取消任务,异步任务完成后继续程序的执行，但同时可以执行其他函数计算
                    await Task.Delay(3000,cancellationToken);
                    completedPercent = (i + 1) * 10;
                }
                catch(TaskCanceledException ex)
                { completedPercent = i * 10; }
                progressBar.Value = completedPercent;
            }
            string message = cancellationToken.IsCancellationRequested
                ? string.Format($"Process was cancelled at {completedPercent}%.")
                : "Process completed normally";
            MessageBox.Show(message, "Completion Status");
            // 关闭窗口后初始化窗口数据
            progressBar.Value    = 0;
            btnProcess.IsEnabled = true;
            btnCancel.IsEnabled  = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (!btnProcess.IsEnabled)
            {
                btnCancel.IsEnabled = false;
                cancellationTokenSource.Cancel();
            }
        }
    }
}