<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

IObservable<DateTimeOffset> ticks = Observable.Interval(TimeSpan.FromSeconds(1))
.Timestamp()
.Select(x => x.Timestamp)
.Take(5);

var display = new ActionBlock<DateTimeOffset>(x => Console.WriteLine(x));
ticks.Subscribe(display.AsObserver());
try
{
	display.Completion.Wait();
	Console.WriteLine("Done");
}
catch (Exception ex)
{
	Console.WriteLine(ex);
}