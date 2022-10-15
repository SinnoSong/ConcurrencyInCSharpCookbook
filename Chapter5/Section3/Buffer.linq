<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

Observable.Interval(TimeSpan.FromSeconds(1))
.Buffer(2)
.Subscribe(x => Console.WriteLine($"{DateTime.Now.Second} : Got {x[0]} and {x[1]}"));