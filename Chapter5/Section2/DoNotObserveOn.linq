<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

Console.WriteLine($"UI Thread is {Environment.CurrentManagedThreadId}");
Observable.Interval(TimeSpan.FromSeconds(1)).Subscribe(x => Console.WriteLine($"Interval {x} on thread {Environment.CurrentManagedThreadId}"));