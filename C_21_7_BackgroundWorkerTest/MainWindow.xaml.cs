using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace C_21_7_BackgroundWorkerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker bgWorker = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();

            // 设置BackgroundWorker属性,设置后台线程是否向主线程汇报,设置后台任务是否支持从主线程取消 
            bgWorker.WorkerReportsProgress = true;   
            bgWorker.WorkerSupportsCancellation = true;

            // 连接BackgroundWorker对象的处理程序
            bgWorker.DoWork += DoWork_Handler;
            bgWorker.ProgressChanged += ProgressChanged_Handler;
            bgWorker.RunWorkerCompleted += RunWorkerCompleted_Handler;
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            if(!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();   // 调用该方法获取后台线程并且执行DoWork事件处理程序
        }

        private void ProgressChanged_Handler(object sender, ProgressChangedEventArgs args)
        {
            progressBar.Value = args.ProgressPercentage;
        }

        /// <summary>
        /// DoWork事件处理程序，包含希望在后台独立线程执行的代码，在后台线程开始的时候触发
        /// </summary>
        /// <param name="sender">触发事件对象的引用</param>
        /// <param name="args">保存状态信息</param>
        private void DoWork_Handler(object sender, DoWorkEventArgs args)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            // 在后台线程中需要定期检查CancellationPending属性，如果为true则取消后台线程
            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending)
                {
                    args.Cancel = true;
                    break;
                }
                else
                {
                    worker.ReportProgress(i * 10);
                    Thread.Sleep(500);
                }
            }    
        }

        private void RunWorkerCompleted_Handler(object sender, RunWorkerCompletedEventArgs args)
        {
            progressBar.Value = 0;
            if(args.Cancelled)
            {
                MessageBox.Show("Process was cancelled.", "Process Cancelled");
            }
            else
            {
                MessageBox.Show("Process completed normally.", "Process Completed");
            }
        }

        /// <summary>
        /// 如果启用了WorkerSupportsCancellation属性，就可以调用对象的CancelAsync方法
        /// 它不会取消后台线程，而是将对象的CancellationPending属性设置为true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            bgWorker.CancelAsync();
        }
    }
}