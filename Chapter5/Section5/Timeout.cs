using System;
using System.Diagnostics;
using System.Linq;
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
              .Select(x => x.EventArgs.GetPosition(this))
                .Timeout(TimeSpan.FromSeconds(1))
                .Subscribe(
                    x => Trace.WriteLine(DateTime.Now.Second + ": Saw " + (x.X + x.Y)),
                    ex => Trace.WriteLine(ex));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var clicks = Observable.FromEventPattern
              <MouseButtonEventHandler, MouseButtonEventArgs>(
                  handler => (s, a) => handler(s, a),
                  handler => MouseDown += handler,
                  handler => MouseDown -= handler)
              .Select(x => x.EventArgs.GetPosition(this));

            Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                  handler => (s, a) => handler(s, a),
                  handler => MouseMove += handler,
                  handler => MouseMove -= handler)
              .Select(x => x.EventArgs.GetPosition(this))
              .Timeout(TimeSpan.FromSeconds(1), clicks)
              .Subscribe(
                  x => Trace.WriteLine(
                      DateTime.Now.Second + ": Saw " + x.X + ", " + x.Y),
                  ex => Trace.WriteLine(ex));
        }
    }
}
