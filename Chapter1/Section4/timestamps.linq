<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

IObservable<DateTimeOffset> timestamps = Observable.Interval(TimeSpan.FromSeconds(1))
.Timestamp()
.Where(x => x.Value % 2 == 0)
.Select(x => x.Timestamp);
timestamps.Subscribe(x => Console.WriteLine(x));