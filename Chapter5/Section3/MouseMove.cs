using System;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                  handler => (s, a) => handler(s, a),
                  handler => MouseMove += handler,
                  handler => MouseMove -= handler)
              .Buffer(TimeSpan.FromSeconds(1))
              .Subscribe(x => Trace.WriteLine(
                  DateTime.Now.Second + ": Saw " + x.Count + " items."));
        }
    }
}
