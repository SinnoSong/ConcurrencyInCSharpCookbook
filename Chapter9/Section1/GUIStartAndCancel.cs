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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource cts;

        public MainWindow()
        {
            InitializeComponent();
        }


        private async void StartClick(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = false;
            CancelButton.IsEnabled = true;

            try
            {
                cts = new CancellationTokenSource();
                var token = cts.Token;
                await Task.Delay(TimeSpan.FromSeconds(5), token);
                MessageBox.Show("Delay completed successfully");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Delay was canceled.");
            }
            catch (Exception)
            {
                MessageBox.Show("Delay completed with error.");
                throw;
            }
            finally
            {
                StartButton.IsEnabled = true;
                CancelButton.IsEnabled = false;
            }
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            cts.Cancel();
        }
    }
}
