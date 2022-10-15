<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>System.Timers</Namespace>
</Query>

var timer = new System.Timers.Timer(interval: 1000) { Enabled = true };
var ticks = Observable.FromEventPattern(timer, "Elapsed");
ticks.Subscribe(data => Console.WriteLine("OnNext:" + ((ElapsedEventArgs)data.EventArgs).SignalTime));