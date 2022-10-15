<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

Observable.Interval(TimeSpan.FromSeconds(1))
.Window(2)
.Subscribe(group =>
{
	Console.WriteLine($"{DateTime.Now.Second} : Starting new group");
	group.Subscribe(
	x => Console.WriteLine($"{DateTime.Now.Second} : Saw {x}"),
	() => Console.WriteLine($"{DateTime.Now.Second} : Ending group")
	);
});