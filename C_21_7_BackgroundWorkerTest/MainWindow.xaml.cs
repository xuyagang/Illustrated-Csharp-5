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
    /// 创建后台线程、构造函数设置属性并添加事件处理程序
    /// 单击按钮调用DoWork事件处理程序，
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker bgWorker = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();

            // 设置BackgroundWorker属性
            bgWorker.WorkerReportsProgress = true;   // 设置后台线程是否向主线程汇报
            bgWorker.WorkerSupportsCancellation = true;   // 设置后台任务是否支持从主线程取消

            // 配置三个事件处理程序
            bgWorker.DoWork += DoWork_Handler;   // 后台线程开始的时候触发
            bgWorker.ProgressChanged += ProgressChanged_Handler;   // 在后台任务汇报进度的时候触发
            bgWorker.RunWorkerCompleted += RunWorkerCompleted_Handler;   // 在后台线程退出的时候触发
        }

        /// <summary>
        /// 单击启动进度条，如果后台线程没有运行，则调用DoWork事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            // 检查后台线程是否在运行
            if(!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();   // 如果没有后台线程运行,调用该方法获取后台线程并且执行DoWork事件处理程序
        }

        /// <summary>
        /// 如果启用了WorkerSupportsCancellation属性，就可以调用对象的CancelAsync方法，请求取消挂起的后台线程
        /// 它不会取消后台线程，而是将对象的CancellationPending属性设置为true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            bgWorker.CancelAsync();
        }



        /// <summary>
        /// DoWork事件处理程序，包含希望在后台独立线程执行的代码
        /// 后台线程开始的时候触发
        /// </summary>
        /// <param name="sender">触发事件对象的引用</param>
        /// <param name="args">保存状态信息</param>
        private void DoWork_Handler(object sender, DoWorkEventArgs args)
        {
            // 创建后台线程
            BackgroundWorker worker = sender as BackgroundWorker;
            // 在后台线程中需要定期检查CancellationPending属性，如果为true则取消后台线程
            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending)   // 是否取消挂起
                {
                    args.Cancel = true;
                    break;
                }
                else
                {
                    // 后台线程通过调用该方法与主线程通信汇报进度，届时将触发ProgressChanged事件
                    // 参数是 已完成的后台操作所占的百分比，范围从 0% 到 100%
                    worker.ReportProgress(i * 10);
                    Thread.Sleep(500);   // 阻塞线程
                }
            }
        }

        /// <summary>
        ///  在后台任务汇报进度的时候触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ProgressChanged_Handler(object sender, ProgressChangedEventArgs args)
        {
            progressBar.Value = args.ProgressPercentage;
        }

        /// <summary>
        /// 在后台线程退出的时候触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
    }
}