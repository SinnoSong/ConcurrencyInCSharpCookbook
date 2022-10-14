<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>System.Timers</Namespace>
</Query>

var timer = new System.Timers.Timer(interval: 1000) { Enabled = true };
var ticks = Observable.FromEventPattern<ElapsedEventHandler, ElapsedEventArgs>(
	handler => (s, a) => handler(s, a),
	handler => timer.Elapsed += handler,
	handler => timer.Elapsed -= handler
);
ticks.Subscribe(data => Console.WriteLine("OnNext:" + data.EventArgs.SignalTime));