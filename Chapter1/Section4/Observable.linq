<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>System.Reactive.Subjects</Namespace>
</Query>

Observable.Interval(TimeSpan.FromSeconds(1))
		  .Timestamp()
		  .Where(x => x.Value % 2 == 0)
		  .Select(x => x.Timestamp)
		  .Subscribe(x => Console.WriteLine(x));