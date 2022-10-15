using System;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace ObserveOn
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

        private void ObserveOn_Click(object sender, RoutedEventArgs e)
        {
            var uiContext = SynchronizationContext.Current;
            Trace.WriteLine("UI thread is " + Environment.CurrentManagedThreadId);
            Observable.Interval(TimeSpan.FromSeconds(1))
              .ObserveOn(uiContext)
              .Subscribe(x => Trace.WriteLine("Interval " + x + " on thread " +
                  Environment.CurrentManagedThreadId));
        }

        private void MouseObserveOn_Click(object sender, RoutedEventArgs e)
        {
            var uiContext = SynchronizationContext.Current;
            Trace.WriteLine("UI thread is " + Environment.CurrentManagedThreadId);
            Observable.FromEventPattern<MouseEventHandler, MouseEventArgs>(
                  handler => (s, a) => handler(s, a),
                  handler => MouseMove += handler,
                  handler => MouseMove -= handler)
              .Select(evt => evt.EventArgs.GetPosition(this))
              .ObserveOn(Scheduler.Default)
              .Select(position =>
              {
                  // 复杂的计算过程。
                  Thread.Sleep(100);
                  var result = position.X + position.Y;
                  Trace.WriteLine("Calculated result " + result + " on thread " +
                      Environment.CurrentManagedThreadId);
                  return result;
              })
              .ObserveOn(uiContext)
              .Subscribe(x => Trace.WriteLine("Result " + x + " on thread " +
                  Environment.CurrentManagedThreadId));
        }
    }
}
