﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace C_21_5_异步Lambda
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            startWorkButton.Click += async (sender, e) =>
            {
                SetGuiValues(false, "Work Started");
                await DoSomeWork();   // 延迟3秒
                SetGuiValues(true, "Work Fineshed");
            };
        }

        private void SetGuiValues(bool buttonEnabled, string status)
        {
            startWorkButton.IsEnabled = buttonEnabled;
            workStartedTextBlock.Text = status;
        }

        private Task DoSomeWork()
        {
            return Task.Delay(3000);
        }

    }
}
