<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

var progress = new Progress<int>();
var progressReports = Observable.FromEventPattern<int>(
	handler => progress.ProgressChanged += handler,
	handler => progress.ProgressChanged -= handler
);
progressReports.Subscribe(data => Console.WriteLine("OnNext:" + data.EventArgs));